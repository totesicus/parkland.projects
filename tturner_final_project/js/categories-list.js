// custom code for parkland bookstore

$(document).ready(function() {
    console.log("Hello final project! Here goes nothing...");

    var url = "https://parkland-csc175.github.io/csc175data/bestbuy/categories-list.json";

    $.getJSON(url, function(data){
        var html = "";
        html += "<table border=\"1\">";
        $.each(data.categories, function(i, category) {
            if ((category.name) == "TVs") {
                html += "<td>" + "<h1>" + "<a href='products-list.html'>" + category.name + "</a>" + "</h1>" + "</td>";
            } else {
                html += "<tr>";
                html += "<td>" + "<h1>" + category.name + "</h1>" + "</td>";
                html += "</tr>";
            };
        });
        html += "</table>";
        $(".row").html(html);
        $("td").css({"padding": "15px", "text-align": "left"});
    });
});