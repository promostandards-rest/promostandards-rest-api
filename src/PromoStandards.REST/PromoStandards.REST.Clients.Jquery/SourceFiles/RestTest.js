$(function () {
    $('.btn').css({
        'border': '1px solid black', 
        'width': '150px',
        'padding': '10px'
    });

    $('.btn-1').click(function (e) {
        //var url = 'https://promostandardsapi.azurewebsites.net/api/Inventory/GetInventoryLevels?wsVersion=1&productId=SL238PR';
        //var url = 'https://promo-rest.createanapi.com/api/prducts?sellable=true&page=0&pageSize=5';
        var url = 'https://promo-rest.createanapi.com/api/products?sellable=true&page=0&pageSize=';
        url = url + $('input#input1').val();
        $.getJSON(url, function (results) {
            console.log(results);
            console.log(results.data[0].productId);
            $('#output1').append('<br>called: ' + url + '<br>');
            i=0;
            $('#output1').append('<br>productId - productName <br>');
            $.each(results.data, function() {
                $('#output1').append(results.data[i].productId + ' - ' + results.data[i].productName + '<br>');
                i++;
            })
        })
    })

    $('.btn-2').click(function (e) {
        //var url = 'https://promo-rest.createanapi.com/api/products/SL238PR/inventory';
        var url = 'https://promo-rest.createanapi.com/api/products/';
        url = url + $('input#input2').val() + '/inventory';
        $.getJSON(url, function (data) {
            console.log(data);
            $('#output2').append('<br>called: ' + url + '<br>');
            $('#output2').append('<br>partId - parColor - labelSize - quantity <br>');
            // returned data set used to have partInventoryArray, now the array is data 09/25/22 change
            //$.each(data.partInventoryArray,function(i,v){
            $.each(data.data,function(i,v){
                $('#output2').append('<br>' + v.partId + ' - ' + v.partColor + ' - ' + v.labelSize + ' - quantity: ' + v.quantityAvailable.quantity.value);
            });
        })
    })

    $('.btn-3').click(function (e) {
        $('#output1').html('<br>Products Sellable here<br>');
        $('#output2').html('<br>Inventory here');
    })
    
})