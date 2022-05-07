$(document).ready(function () {
    $(".bo-nav-responsive").on("click", function () {
        if ($(".bo-nav").css("display") == "none")
            $(".bo-nav").css("display", "block");
        else
            $(".bo-nav").css("display", "none");
    });
});