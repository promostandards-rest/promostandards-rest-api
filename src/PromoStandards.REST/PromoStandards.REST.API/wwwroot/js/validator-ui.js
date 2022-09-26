(function () {
    ;
    $(document).ready(function () {

        $("#splitter").kendoSplitter({
            panes: [
                { collapsible: true, min: "100px", max: "800px" },
                { collapsible: true, min: "100px", max: "800px" }
            ],
            orientation: "vertical"
        });

        $("#validate").on("click", function () {

            let url = $("#input-url").val();

            if (!url) {
                toastr.error("No URL");
                return;
            }

            $.ajax({
                url: url,
                type: "GET",
                dataType: 'json',
                cache: false,
                async: false,
                contentType: "application/json; charset=utf-8",
                success: function (response) {

                    //let data = response.data || response;

                    $("code#response").html(library.json.prettyPrint(response));

                    let payload = {
                        jsonData: JSON.stringify(response),
                        schemaId: "product"
                    };

                    $.ajax({
                        url: "/api/validate",
                        type: "POST",
                        dataType: 'json',
                        data: JSON.stringify(payload),
                        contentType: "application/json; charset=utf-8",
                        cache: false,
                        success: function (response) {
                            $("code#results").html(library.json.prettyPrint(response));
                        },
                        error: function (xhr, status) {
                            toastr.error(xhr?.statusText || status, "An error has occured");
                        }
                    });

                },
                error: function (xhr, status) {
                    toastr.error(status, "An error has occured");
                }
            });
        });



        if (!library)
            var library = {};

        library.json = {
            replacer: function (match, pIndent, pKey, pVal, pEnd) {
                var key = '<span class=json-key>';
                var val = '<span class=json-value>';
                var str = '<span class=json-string>';
                var r = pIndent || '';
                if (pKey)
                    r = r + key + pKey.replace(/[": ]/g, '') + '</span>: ';
                if (pVal)
                    r = r + (pVal[0] == '"' ? str : val) + pVal + '</span>';
                return r + (pEnd || '');
            },
            prettyPrint: function (obj) {
                var jsonLine = /^( *)("[\w]+": )?("[^"]*"|[\w.+-]*)?([,[{])?$/mg;
                return JSON.stringify(obj, null, 3)
                    .replace(/&/g, '&amp;').replace(/\\"/g, '&quot;')
                    .replace(/</g, '&lt;').replace(/>/g, '&gt;')
                    .replace(jsonLine, library.json.replacer);
            }
        };

    });
})();