(function( $ ) {
 
    $.fn.menuify = function() {
        
        $(".movies").hide();

        return $("li").each(function(i) {

                $("a[data-target='episode-one']").click(function(){
                    $("#episode-one").fadeIn(500);

                    $("#episode-one").css({"background-color": "black", "color": "yellow"});
                    var $tag = $(this);
                    $tag.css("color", "yellow");
                    $tag.parent().css("background-color", "black");

                    $("#episode-two").fadeOut(500);
                    $("#episode-three").fadeOut(500);
                    $("#episode-four").fadeOut(500);
                    $("#episode-five").fadeOut(500);
                    $("#episode-six").fadeOut(500);
                });

                $("a[data-target='episode-two']").click(function(){
                    $("#episode-two").fadeIn(500);

                    $("#episode-two").css({"background-color": "black", "color": "yellow"})
                    var $tag = $(this);
                    $tag.css("color", "yellow");
                    $tag.parent().css("background-color", "black");

                    $("#episode-one").fadeOut(500);
                    $("#episode-three").fadeOut(500);
                    $("#episode-four").fadeOut(500);
                    $("#episode-five").fadeOut(500);
                    $("#episode-six").fadeOut(500);
                });

                $("a[data-target='episode-three']").click(function(){
                    $("#episode-three").fadeIn(500);

                    $("#episode-three").css({"background-color": "black", "color": "yellow"});
                    var $tag = $(this);
                    $tag.css("color", "yellow");
                    $tag.parent().css("background-color", "black");

                    $("#episode-one").fadeOut(500);
                    $("#episode-two").fadeOut(500);
                    $("#episode-four").fadeOut(500);
                    $("#episode-five").fadeOut(500);
                    $("#episode-six").fadeOut(500);
                });

                $("a[data-target='episode-four']").click(function(){
                    $("#episode-four").fadeIn(500);

                    $("#episode-four").css({"background-color": "black", "color": "yellow"});
                    var $tag = $(this);
                    $tag.css("color", "yellow");
                    $tag.parent().css("background-color", "black");

                    $("#episode-one").fadeOut(500);
                    $("#episode-two").fadeOut(500);
                    $("#episode-three").fadeOut(500);
                    $("#episode-five").fadeOut(500);
                    $("#episode-six").fadeOut(500);
                });

                $("a[data-target='episode-five']").click(function(){
                    $("#episode-five").fadeIn(500);

                    $("#episode-five").css({"background-color": "black", "color": "yellow"});
                    var $tag = $(this);
                    $tag.css("color", "yellow");
                    $tag.parent().css("background-color", "black");

                    $("#episode-one").fadeOut(500);
                    $("#episode-two").fadeOut(500);
                    $("#episode-three").fadeOut(500);
                    $("#episode-four").fadeOut(500);
                    $("#episode-six").fadeOut(500);
                });

                $("a[data-target='episode-six']").click(function(){
                    $("#episode-six").fadeIn(500);

                    $("#episode-six").css({"background-color": "black", "color": "yellow"});
                    var $tag = $(this);
                    $tag.css("color", "yellow");
                    $tag.parent().css("background-color", "black");
                    
                    $("#episode-one").fadeOut(500);
                    $("#episode-two").fadeOut(500);
                    $("#episode-three").fadeOut(500);
                    $("#episode-four").fadeOut(500);
                    $("#episode-five").fadeOut(500);
                });
            });
    };
 
}( jQuery ));

$(document).ready(function() {
    $("#movie-menu").menuify();
});