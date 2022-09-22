// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


$("#validate").on("click", function () {

    let url = $("#input-url").val();

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

            let data = response.data || response;

            $("code").html(library.json.prettyPrint(data));
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

