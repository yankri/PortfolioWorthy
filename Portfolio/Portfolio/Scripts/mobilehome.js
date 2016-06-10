//function to hide all elements so I dont have to do it manually each time
function hideAll() {
    $("#stuffpage").hide();
    $('#edupage').hide();
    $('#contactpage').hide();
    $('#skillspage').hide();
    $('#aboutpage').hide();
    $("#mobiledino").hide();
};
$(document).ready(function () {
    $("#skills").click(function (e) {
        hideAll();
        $('#skillspage').show("slide", { direction: "right" }, 400);
    });
});
$("#skills").hover(function () {
    $(this).stop().css({
        "cursor": "pointer"
    })
});
$(document).ready(function () {
    $("#contact").click(function (e) {
        hideAll();
        $('#contactpage').show("slide", { direction: "right" }, 400);
    });
});
$("#contact").hover(function () {
    $(this).stop().css({
        "cursor": "pointer"
    })
});
$(document).ready(function () {
    $("#education").click(function (e) {
        hideAll();
        $('#edupage').show("slide", { direction: "right" }, 400);
    });
});
$("#education").hover(function () {
    $(this).stop().css({
        "cursor": "pointer"
    })
});
$(document).ready(function () {
    $("#about").click(function (e) {
        hideAll();
        $('#aboutpage').show("slide", { direction: "right" }, 400);
    });
});
$("#about").hover(function () {
    $(this).stop().css({
        "cursor": "pointer"
    })
});

$("#otherstuff").hover(function () {
    $(this).stop().css({
        "cursor": "pointer"
    })
});