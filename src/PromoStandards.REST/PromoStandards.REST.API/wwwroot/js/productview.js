
        $('#btn-call-product-view').click(function() {
            $('#product-parts').html("");
            var productId = $('#product-id').val();
            buildProductDetails(productId);
            buildImages(productId);
        });

        const galleryWidget = $('#gallery').dxGallery({
            dataSource: [],
            height: 300,
            loop: true,
            slideshowDelay: 2000,
            showNavButtons: true,
            showIndicator: true,
            itemTemplate(item) {
                const result = $('<div>');
                $('<img width="auto" height="300">').attr('src', item.url).appendTo(result);
                return result;
            },
        }).dxGallery('instance');

        function buildProductDetails(productId) {
            $.ajax({
                type: "GET",
                dataType: 'json',
                url: "/api/products/" + productId,
                crossDomain: true,
                cache: false,
                xhrFields: {
                    withCredentials: true
                },
                async: false,
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    $('#product-name').html(response.productName);
                    var description = "";
                    $('#product-description').html(response.description.join(","));
                    var parts = $("<ul>");
                    for (var i = 0; i < response.productPartArray.length; i++) {
                        var partData = response.productPartArray[i];
                        var color = "";
                        if (partData.colorArray.length > 0) {
                            color = partData.colorArray[0].colorName;
                        }
                        const part = $("<li>").attr("id",partData.partId);
                        part.html(partData.partId + ": " + color + " - " + partData.description.join(","));
                        parts.append(part);
                    }
                    $('#product-parts').append(parts);
                    buildInventory(productId);
                },
                error: function (xhr, status) {
                    toastr.error(status, "An error has occured");
                }
            });
        }
        function buildInventory(productId) {
            $.ajax({
                type: "GET",
                dataType: 'json',
                url: "/api/products/" + productId + "/inventory",
                crossDomain: true,
                cache: false,
                xhrFields: {
                    withCredentials: true
                },
                async: false,
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    console.log(response);
                    for (var i = 0; i < response.data.length; i++) {
                        $('#' + response.data[i].partId).append(" - Quantity: " + response.data[i].quantityAvailable.quantity.value);
                    }
                },
                error: function (xhr, status) {
                    toastr.error(status, "An error has occured");
                }
            });
        }
        function buildImages(productId) {
            $.ajax({
                type: "GET",
                dataType: 'json',
                url: "/api/products/" + productId + "/images",
                crossDomain: true,
                cache: false,
                xhrFields: {
                    withCredentials: true
                },
                async: false,
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    galleryWidget.option("dataSource", response.data);
                },
                error: function (xhr, status) {
                    toastr.error(status, "An error has occured");
                }
            });
        }
        function buildDocuments() {

        }
        function buildVideos() {

        }