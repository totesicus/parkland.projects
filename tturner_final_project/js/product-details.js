// custom code for parkland bookstore

$(document).ready(function(){

    // I found this function on StackOverflow. It pulls data from the URL and allows us to use $.urlParam() to access it.
    $.urlParam = function(name){
        var results = new RegExp('[\?&]' + name + '=([^&#]*)').exec(window.location.href);
        return results[1] || 0;
    }

    console.log("The Product ID is " + $.urlParam('productId'));

    var clickedProductID = $.urlParam('productId');

    var url = "https://parkland-csc175.github.io/csc175data/bestbuy/products-list.json";

    $.getJSON(url, function(data){
        $.each(data.products, function(i, product){
            if (product.productId == clickedProductID) {
                console.log("GOTCHA");
                $(".caption-full a").text(product.name);
                $(".caption-full .pull-right").text("$" + product.regularPrice);
            }
        });
    });
});