﻿
function hideAll() {
    $("#stuffpage").hide();
    $('#edupage').hide();
    $('#contactpage').hide();
    $('#skillspage').hide();
    $('#aboutpage').hide();
};
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

$(document).ready(function () {
    $("#stuffImade").mouseenter(function (e) {
        $("#stuffmenu").css({
            top: "180px",
            left: "310px",
        });
        $("#stuffmenu").toggle("slide", { direction: "up" }, 400);
    });
    $("#stuffImade").mouseout(function (e) {
        $("#stuffmenu").hide();
    });
});
$(document).ready(function () {
    $("#about").mouseenter(function (e) {
        $("#aboutmenu").css({
            top: "238px",
            left: "364px"
        });
        $("#aboutmenu").toggle("slide", { direction: "up" }, 400);
    });
    $("#about").mouseout(function (e) {
        $("#aboutmenu").hide();
    });
});
$(document).ready(function () {
    $("#skills").mouseenter(function (e) {
        $("#skillsmenu").css({
            top: "295px",
            left: "420px"
        });
        $("#skillsmenu").toggle("slide", { direction: "up" }, 400);
    });
    $("#skills").mouseout(function (e) {
        $("#skillsmenu").hide();
    });
});
$(document).ready(function () {
    $("#contact").mouseenter(function (e) {
        $("#contactmenu").css({
            top: "70px",
            left: "490px"
        });
        $("#contactmenu").toggle("slide", { direction: "down" }, 400);
    });
    $("#contact").mouseout(function (e) {
        $("#contactmenu").hide();
    });
});
$(document).ready(function () {
    $("#otherstuff").mouseenter(function (e) {
        $("#otherstuffmenu").css({
            top: "20px",
            left: "560px"
        });
        $("#otherstuffmenu").toggle("slide", { direction: "down" }, 400);
    });
    $("#otherstuff").mouseout(function (e) {
        $("#otherstuffmenu").hide();
    });
});
$(document).ready(function () {
    $("#education").mouseenter(function (e) {
        $("#edumenu").css({
            top: "210px",
            left: "705px",
        });
        $("#edumenu").toggle("slide", { direction: "down" }, 400);
    });
    $("#education").mouseout(function (e) {
        $("#edumenu").hide();
    });
});

