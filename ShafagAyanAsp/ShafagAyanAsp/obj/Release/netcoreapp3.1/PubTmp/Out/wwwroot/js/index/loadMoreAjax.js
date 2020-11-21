"use strict"

var imageCount = 4;
var videoCount = 4;
var totalImage = $("#load-more-image").attr("data-image");
var totalVideo = $("#load-more-video").attr("data-video");

$("#load-more-image").click(function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Ajax/LoadMoreImage?skipCount=" + imageCount,
        method: "GET",
        success: function (response) {
            $(".load-image").append(response);
            imageCount += 4;
            if (imageCount >= totalImage) {
                $("#load-more-image").css("opacity", "0");
            }
        }
    })
})

$("#load-more-video").click(function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Ajax/LoadMoreVideo?skipCount=" + videoCount,
        method: "GET",
        success: function (response) {
            $(".load-video").append(response);
            videoCount += 4;
            if (videoCount >= totalVideo) {
                $("#load-more-video").css("opacity", "0");
            }
        }
    })
})