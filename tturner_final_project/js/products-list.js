// custom code for parkland bookstore

$(document).ready(function(){
    console.log("Hello final project! Here goes nothing...");
    
    var url = "https://parkland-csc175.github.io/csc175data/bestbuy/products-list.json";

    $.getJSON(url, function(data){
        var html = "";
        html += "<table border=\"1\">";
        html += "<tr>" + "<th><h2>SKU</h2></th>" + "<th><h2>Name</h2></th>" + "<th><h2>Price</h2></th>" + "</tr>";
        $.each(data.products, function(i, product){
            html += "<tr>";
            html += "<td>" + product.sku + "</a>" + "</td>";
            html += "<td>" + "<a href=product-details.html?productId=" + product.productId + ">" + product.name + "</td>";
            html += "<td>" + "$" + product.regularPrice + "</td>";
            html += "</tr>";
        })
        html += "</table>";
        $(".row").html(html);
        $("table").css({"margin": "0 auto"});
        $("td").css({"padding": "15px", "text-align": "left"});
        $("th").css({"padding": "15px", "text-align": "center"});
    })

})