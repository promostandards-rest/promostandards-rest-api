(function () {
    ;
    $(document).ready(function () {

        const defaultDisplayedFieldCount = 5;

        let schemas = [];
        let currentObject = "";

        $("#splitter").kendoSplitter({
            orientation: "vertical"
        });

        $.ajax({
            type: "GET",
            dataType: 'json',
            url: urlDomain + "/swagger/v1/swagger.json",
            crossDomain: true,
            cache: false,
            xhrFields: {
                withCredentials: true
            },
            async: false,
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                schemas = response.components.schemas;
            },
            error: function (xhr, status) {
                toastr.error(status, "An error has occured");
            }
        });

        // Upon dropdown selection, set the url into the textbox
        $("#api-section select").on("change", function () {
            $("#api-section input[type='text']").val($("#api-section select option:selected").val());
        });
        $("#api-section input[type='text']").val($("#api-section select option:selected").val());

        $("#btn-call-api").on("click", callApi);

        let column = function (fieldName, title, width) {
            // Builds the config used for the grid's column

            let field = schemas[currentObject].properties[fieldName];
            let controlsActive = title?.trim().length > 0;

            let config = {
                field: fieldName,
                title: title || fieldName,
                sortable: controlsActive,
                resizable: controlsActive,
                filterable: controlsActive
            };

            if (field?.format == "date-time") {
                config.format = "{0: yyyy-MM-dd HH:mm:ss}";
            }

            if (width) {
                config.width = width;
            }

            if (fieldName == "selectable") {
                config.selectable = true;
            }

            return config;
        }

        function callApi() {

            let selectedOption = $("select option:selected");
            let url = $("#api-section input[type='text']").val() || selectedOption.val();
            let title = selectedOption.data("title");
            currentObject = selectedOption.data("id");

            // Add link to screen
            $("#api-section a").attr("href", urlDomain + url);
            $("#api-section a span").html(url);
            $("#api-section input[type='text']").val(url);

            // Relabel grid titles
            $("#schemaGrid h5").html(`Schema for ${title} Object`);
            $("#dataGrid h5").html(`${title} Data Collection`);

            getDataAndbuildGrids(urlDomain + url);
        }

        function getDataAndbuildGrids(url) {

            if (!url) {
                toastr.error("No URL");
                return;
            }

            $.ajax({
                type: "GET",
                dataType: 'json',
                url: url,
                crossDomain: true,
                xhrFields: {
                    withCredentials: true
                },
                cache: false,
                async: false,
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    buildGrids(transformData(response.data || [response]));
                },
                error: function (xhr, status) {
                    let inputUrl = $("#api-section input[type='text']").val();
                    let selectUrl = $("#api-section select option:selected").val();
                    if (inputUrl == selectUrl) {
                        toastr.error(status, "An error has occured");
                    } else {
                        // Assume error is with input query
                        $("#api-section input[type='text']").val($("#api-section select option:selected").val());
                        callApi();
                    }
                }
            });
        }

        function transformData(data) {
            // Any client side changes to the data should gets done here


            if (Array.isArray(data)) {

            } else
                data.forEach(obj => {

                    let schema = schemas[currentObject];

                    Object.keys(obj).forEach(fieldName => {
                        let fieldSchema = schema.properties[fieldName];

                        if (fieldSchema.type == "array") {
                            if (fieldSchema.items.type == "string") {
                                // Comma separate fields that are array of type string
                                obj[fieldName] = obj[fieldName].join(", ");
                            } else {
                                //delete obj[fieldName];
                                obj[fieldName] = "[Array]";
                            }
                        }

                        if (fieldSchema.format == "date-time")
                            // Transform date string into javascript date
                            obj[fieldName] = new Date(obj[fieldName]);
                    });
                });

            return data;
        }

        function transformSchema(schema) {
            // Builds the data the grid needs using the schema details

            let schemaData = [];

            Object.keys(schema.properties).forEach(fieldName => {
                let field = schema.properties[fieldName];
                let data = {
                    fieldName: fieldName,
                    description: field.description,
                    datatype: field.type,
                    required: schema.required?.some(r => r == fieldName) ?? false
                };
                schemaData.push(data);
            });

            return schemaData;
        }

        function buildGrids(data) {

            let schemaCols = [
                column("selectable", " ", "50px"),
                column("fieldName", "Field", "250px"),
                column("description", "Description"),
                column("datatype", "Type", "100px"),
                column("required", "Required", "100px")
            ];
            let schemaData = transformSchema(schemas[currentObject]);

            let schemaGrid = $("#schemaGrid .grid").data("kendoGrid");

            schemaGrid?.destroy();

            $("#schemaGrid .grid").kendoGrid({
                width: "100%",
                sortable: true,
                filterable: true,
                resizable: true,
                columnResizeHandleWidth: 5,
                columns: schemaCols,
                dataSource: {
                    data: schemaData
                },
                change: function () {
                    let dataGrid = $("#dataGrid .grid").data("kendoGrid");
                    dataGrid.dataSource.fetch(function () {
                        let dataSet = dataGrid.dataSource.data();
                        rebuildDataGrid(dataSet, true);
                    });
                }
            });

            setTimeout(() => {
                // Preselect some fields to display in the data grid
                let schemaGrid = $("#schemaGrid .grid").data("kendoGrid");
                let selectQuery = "";
                for (let i = 0; i < defaultDisplayedFieldCount; i++) {
                    if (selectQuery) selectQuery += ", ";
                    selectQuery += `tr:eq(${i})`;
                }
                schemaGrid.select(selectQuery)
            });

            rebuildDataGrid(data);
        }

        function rebuildDataGrid(dataSet, rebuildColumns) {

            if (!dataSet || dataSet.length == 0) {
                console.error("Cannot build grid, no data supplied");
                return;
            }

            let dataGrid = $("#dataGrid .grid").data("kendoGrid");

            let cols = [];
            // Build array of columns
            Object.keys(dataSet[0]).forEach(fieldName => {
                let fieldSchema = schemas[currentObject].properties[fieldName];
                //if (fieldSchema.type != "array") {
                if (rebuildColumns || !rebuildColumns && cols.length < defaultDisplayedFieldCount) {
                    cols.push(column(fieldName));
                }
                //}
            });

            if (rebuildColumns) {

                // Only show columns that are selected 

                let schemaGrid = $("#schemaGrid .grid").data("kendoGrid");
                let selectedFields = [];

                $.each(schemaGrid.select(), (i, element) => {
                    selectedFields.push(schemaGrid.dataItem(element).fieldName);
                });

                cols.forEach(col => {
                    col.hidden = !selectedFields.includes(col.field);
                });

                dataGrid.setOptions({ columns: cols });

            }
            else {

                dataGrid?.destroy();
                $("#dataGrid .grid").html("");
                $("#dataGrid .grid").kendoGrid({
                    width: "100%",
                    filterable: true,
                    sortable: true,
                    resizable: true,
                    columnResizeHandleWidth: 5,
                    columns: cols,
                    dataSource: { data: dataSet }
                });
            }
        }
    });
})();