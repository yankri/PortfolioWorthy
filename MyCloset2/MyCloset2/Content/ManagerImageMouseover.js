var offsetX = 20;
var offsetY = 10;

$('.popup').hover(function(e) {
    var href = $(this).attr('href');
    $('<img id="largeImage" src="' + href + '" alt="big image" height="200" width="200"/>')
    .css('top', e.pageY + offsetY)
    .css('left', e.pageX + offsetX)
    .appendTo('body');
}, function() {
    $('#largeImage').remove();
});

$('.popup').mousemove(function(e) {
    $("#largeImage").css('top', e.pageY + offsetY).css('left', e.pageX + offsetX);
});
