// Julian Jackson CS4443XTIB-18T4
var canvas = document.getElementById("billboard-canvas");
var canvas_context = canvas.getContext("2d");
canvas_context.fillStyle = "black";
canvas_context.fillRect(0, 0, canvas.width, canvas.height);
canvas_context.strokeStyle ='#FFF';
canvas_context.lineWidth = 1;
canvas_context.lineCap = 'straight';
function draw_rain() {
    var billboard = document.getElementById("billboard");
    var video = document.getElementById("billboard-video");
    var billboard_height = parseInt(billboard.clientHeight);
    var scrollVal = parseInt(window.pageYOffset || document.documentElement.scrollTop);
    // determine if page is scrolled out. If so, stop raining to save resources
    var rainCount = parseInt((billboard_height - scrollVal) / 80) - 1;
    // pause the video if it's not raining, otherwise play
    if (rainCount < 1)
    {
        video.pause();
    }
    else
    {
        if (video.paused)
        {
            video.play();
        }
    }
    canvas_context.fillRect(0, 0, canvas.width, canvas.height);
    for (var i = 0; i < rainCount; i++) {
        var rain_height = Math.random() * 7;
        var rain_x = Math.random() * canvas.width;
        var rain_y = Math.random() * canvas.height;

        canvas_context.beginPath();
        canvas_context.moveTo(rain_x, rain_y);
        canvas_context.lineTo(rain_x, rain_y + rain_height);
        canvas_context.stroke();
    }
}

setInterval(draw_rain, 50);