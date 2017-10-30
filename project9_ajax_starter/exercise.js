$(document).ready(function(){

    var startURL = "http://parkland-csc175.github.io/instructor-example/";

    $.get(startURL + "api/episode-list.json", function(data) {
        $("#movie-menu").text("");
        $(".col-md-12 h1").text("");
        $(".col-md-12 p").text("");

        $.each(data, function(i, episode){
            var $anchor = $("<a href='#'></a>");
            var $li = $("<li></li>");

            $anchor.attr("id", "episode-" + episode.id);
            $anchor.text(episode.name);
            $li.append($anchor);
            $("#movie-menu").append($li);

            $anchor.click(createClickHandler(startURL + episode.url));
        });  
    });

    function createClickHandler(url) {
        return function onClick(){
            $.get(url, function(data){
                $("#episode-container h1").text(data.title);
                $("#episode-container p").text(data.description);
            });     
        }
    }

    // $(".col-md-12 h1").text("");
    // $(".col-md-12 p").text("");
    
    // var movieMenuURL = "http://parkland-csc175.github.io/instructor-example/api/episode-list.json";

    // $.getJSON(movieMenuURL, function(data){
    //     var html = "";
    //     $.each (data, function(i, ep) {
    //         html += "<li>" + "<a href='#' id='episode-" + ep.id + "'>" + ep.name + "</a>" + "</li>";
    //     })
        
    //     $("#movie-menu").html(html);
    // })
	
    // $("#episode-1").click(function() {

    //     var url = "http://parkland-csc175.github.io/instructor-example/api/episode-1.json";

    //     $.getJSON(url, function(data){
    //         $(".col-md-12 h1").text(data.title);
    //         $(".col-md-12 p").text(data.description);
    //     })
    // })

    // $("#episode-2").click(function() {

    //     var url = "http://parkland-csc175.github.io/instructor-example/api/episode-2.json";

    //     $.getJSON(url, function(data){
    //         $(".col-md-12 h1").text(data.title);
    //         $(".col-md-12 p").text(data.description);
    //     })
    // })

    // $("#episode-3").click(function() {

    //     var url = "http://parkland-csc175.github.io/instructor-example/api/episode-3.json";

    //     $.getJSON(url, function(data){
    //         $(".col-md-12 h1").text(data.title);
    //         $(".col-md-12 p").text(data.description);
    //     })
    // })

    // $("#episode-4").click(function() {

    //     var url = "http://parkland-csc175.github.io/instructor-example/api/episode-4.json";

    //     $.getJSON(url, function(data){
    //         $(".col-md-12 h1").text(data.title);
    //         $(".col-md-12 p").text(data.description);
    //     })
    // })

    // $("#episode-5']").click(function() {

    //     var url = "http://parkland-csc175.github.io/instructor-example/api/episode-5.json";

    //     $.getJSON(url, function(data){
    //         $(".col-md-12 h1").text(data.title);
    //         $(".col-md-12 p").text(data.description);
    //     })
    // })

    // $("#episode-6").click(function() {

    //     var url = "http://parkland-csc175.github.io/instructor-example/api/episode-6.json";

    //     $.getJSON(url, function(data){
    //         $(".col-md-12 h1").text(data.title);
    //         $(".col-md-12 p").text(data.description);
    //     })
    // })
        
    });