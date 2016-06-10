//function to hide all elements so I dont have to do it manually each time
function hideAll() {
    $("#stuffpage").hide();
    $('#edupage').hide();
    $('#contactpage').hide();
    $('#skillspage').hide();
    $('#aboutpage').hide();
    $("#mobiledino").hide();
};

//these functions control the hide/show of the individual content elements
$(document).ready(function () {
    $("#skills").click(function (e) {
        $('#skillspage').css({
            top: "50px",
            right: "100px"
        });
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
        $('#contactpage').css({
            top: "50px",
            right: "250px"
        });
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
        $('#edupage').css({
            top: "50px",
            right: "100px"
        });
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
        $('#aboutpage').css({
            top: "50px",
            right: "50px"
        });
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

//these functions control the menu text sliding in
$(document).ready(function () {
    $("#stuffImade").mouseenter(function (e) {
        var elementAt = e.target;
        var rect = elementAt.getBoundingClientRect();
        var width = rect.right - rect.left;
        var elewidth = $("#stuffmenu").width();
        $("#stuffmenu").css({
            top: rect.bottom - elewidth + "px",
            left: (rect.left + width/2 - elewidth) + "px",
        });
        $("#stuffmenu").toggle("slide", { direction: "up" }, 400);
    });
    $("#stuffImade").mouseout(function (e) {
        $("#stuffmenu").hide();
    });
});
$(document).ready(function () {
    $("#about").mouseenter(function (e) {
        var elementAt = e.target;
        var rect = elementAt.getBoundingClientRect();
        var width = rect.right - rect.left;
        var elewidth = $("#aboutmenu").width();
        $("#aboutmenu").css({
            top: rect.bottom - elewidth + "px",
            left: (rect.left + width / 2 - elewidth) + "px",
        });
        $("#aboutmenu").toggle("slide", { direction: "up" }, 400);
    });
    $("#about").mouseout(function (e) {
        $("#aboutmenu").hide();
    });
});
$(document).ready(function () {
    $("#skills").mouseenter(function (e) {
        var elementAt = e.target;
        var rect = elementAt.getBoundingClientRect();
        var width = rect.right - rect.left;
        var elewidth = $("#skillsmenu").width();
        $("#skillsmenu").css({
            top: rect.bottom - elewidth + "px",
            left: (rect.left + width / 2 - elewidth) + "px",
        });
        $("#skillsmenu").toggle("slide", { direction: "up" }, 400);
    });
    $("#skills").mouseout(function (e) {
        $("#skillsmenu").hide();
    });
});
//ones that go above the name
$(document).ready(function () {
    $("#contact").mouseenter(function (e) {
        var elementAt = e.target;
        var rect = elementAt.getBoundingClientRect();
        var width = rect.right - rect.left;
        var height = $("#contactmenu").height();
        var elewidth = $("#contactmenu").width();
        $("#contactmenu").css({
            top: rect.top - height + elewidth + "px",
            left: (rect.left + width / 2 + elewidth/2) + "px",
        });
        $("#contactmenu").toggle("slide", { direction: "down" }, 400);
    });
    $("#contact").mouseout(function (e) {
        $("#contactmenu").hide();
    });
});
$(document).ready(function () {
    $("#otherstuff").mouseenter(function (e) {
        var elementAt = e.target;
        var rect = elementAt.getBoundingClientRect();
        var width = rect.right - rect.left;
        var height = $("#otherstuffmenu").height();
        var elewidth = $("#otherstuffmenu").width();
        $("#otherstuffmenu").css({
            top: rect.top - height + elewidth + "px",
            left: (rect.left + width / 2 + elewidth / 2) + "px",
        });
        $("#otherstuffmenu").toggle("slide", { direction: "down" }, 400);
    });
    $("#otherstuff").mouseout(function (e) {
        $("#otherstuffmenu").hide();
    });
});
$(document).ready(function () {
    $("#education").mouseenter(function (e) {
        var elementAt = e.target;
        var rect = elementAt.getBoundingClientRect();
        var width = rect.right - rect.left;
        var height = $("#edumenu").height();
        var elewidth = $("#edumenu").width();
        $("#edumenu").css({
            top: rect.top - height + elewidth + "px",
            left: (rect.left + width / 2 + elewidth / 2) + "px",
        });
        $("#edumenu").toggle("slide", { direction: "down" }, 400);
    });
    $("#education").mouseout(function (e) {
        $("#edumenu").hide();
    });
});


