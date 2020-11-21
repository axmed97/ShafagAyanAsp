"use strict"

window.onload = function(){
  let preloader = document.getElementById('preloader');
  preloader.style.opacity = '0';
  preloader.style.visibility = 'hidden';
  $('body').css('overflow','visible');
}

$('.venobox').venobox({
  framewidth : '500px',
  frameheight: 'auto',
  spinner: "cube-grid",
  spinColor: "#edd5cf",
  closeColor: "#edd5cf",
  arrowsColor: "#edd5cf",
  infinigall: true
})
$('.venabox-video').venobox({
  autoplay: true,
  spinner: "cube-grid",
  spinColor: "#edd5cf",
  closeColor: "#edd5cf",
  arrowsColor: "#edd5cf",
  infinigall: true
});

let navigationMenu = document.querySelector('.navigation-menu');

$('.home-slider').slick({
    infinite: true,
    autoplay: true,
    autoplaySpeed: 4000,
    cssEase: 'linear',
    fade: true
});

const menuBtn = document.querySelector('.menu-btn');
const sideMenu = document.querySelector('.side-menu');
let menuOpen = false;

menuBtn.addEventListener('click', function(){
    if(!menuOpen){
        menuBtn.classList.add('open');
        menuOpen = true;
        sideMenu.classList.add('active-side-menu');
    }
    else{
        menuBtn.classList.remove('open');
        menuOpen = false;
        sideMenu.classList.remove('active-side-menu');
        accMenu.classList.remove('active-acc-menu');
    }
});

window.addEventListener('scroll', function(){
    navigationMenu.classList.toggle('sticky', window.scrollY > 0);
});

// $('.login-box').click(function(){
//     $('.login-form').removeClass('active-login-form');
//     $('.login-box').addClass('selected');
//     $('.register-box').removeClass('selected');
//     $('.register-form').removeClass('active-register-form');
// });

// $('.register-box').click(function(){
//     $('.login-form').addClass('active-login-form');
//     $('.login-box').removeClass('selected');
//     $('.register-box').addClass('selected');
//     $('.register-form').addClass('active-register-form');
// });

// $('.login-info').click(function(){
//     $('.form-section').addClass('active-form-section');
//     $('.form-bgcolor').addClass('active-form-bgcolor');
//     $('body').css({
//         'overflow':'hidden'
//     });
// });

// $('.form-close-btn').click(function(){
//     $('.form-section').removeClass('active-form-section');
//     $('.form-bgcolor').removeClass('active-form-bgcolor');
//     $('body').css({
//         'overflow':'visible'
//     });
//     sideMenu.classList.remove('active-side-menu');
//     menuBtn.classList.remove('open');
//     menuOpen = false;
// });

// $('.form-bgcolor').click(function(){
//     $('.form-section').removeClass('active-form-section');
//     $('.form-bgcolor').removeClass('active-form-bgcolor');
//     $('body').css({
//         'overflow':'visible'
//     });
//     sideMenu.classList.remove('active-side-menu');
//     menuBtn.classList.remove('open');
//     menuOpen = false;
// });

// $('.responsive-login-info-btn').click(function(){
//     $('.form-section').addClass('active-form-section');
//     $('.form-bgcolor').addClass('active-form-bgcolor');
//     $('body').css({
//         'overflow':'hidden'
//     });
//     sideMenu.classList.add('active-side-menu');
//     menuBtn.classList.remove('open');
//     menuOpen = false;
// });

$(document).ready(function() {
  
    var scrollLink = $('.scroll');
    
    // Smooth scrolling
    scrollLink.click(function(e) {
      e.preventDefault();
      $('body,html').animate({
        scrollTop: $(this.hash).offset().top
      }, 1000 );
    });
    
    // Active link switching
    $(window).scroll(function() {
      var scrollbarLocation = $(this).scrollTop();
      
      scrollLink.each(function() {
        
        var sectionOffset = $(this.hash).offset().top - 20;
        
        if ( sectionOffset <= scrollbarLocation ) {
          $(this).parent().addClass('active-link');
          $(this).parent().siblings().removeClass('active-link');
        }
      })
      
    })
    
  })
  
  $(document).ready(function() {
  
    var scrollLink = $('.resp-scroll');
    
    // Smooth scrolling
    scrollLink.click(function(e) {
      e.preventDefault();
      $('body,html').animate({
        scrollTop: $(this.hash).offset().top
      }, 1000 );
    });
    
    // Active link switching
    $(window).scroll(function() {
      var scrollbarLocation = $(this).scrollTop();
      
      scrollLink.each(function() {
        
        var sectionOffset = $(this.hash).offset().top - 20;
        
        if ( sectionOffset <= scrollbarLocation ) {
          $(this).parent().addClass('active-side-link');
          $(this).parent().siblings().removeClass('active-side-link');
          menuBtn.classList.remove('open');
        menuOpen = false;
        sideMenu.classList.remove('active-side-menu');
        }
      })
      
    })
    
  })

  var scrollabout = $('.about-scroll');

  scrollabout.click(function(e) {
    e.preventDefault();
    $('body,html').animate({
      scrollTop: $(this.hash).offset().top
    }, 1000 );
  });
  
  // $(".acc-a").click(function(){
  //   sideMenu.classList.remove('active-side-menu');
  //   menuBtn.classList.remove('open');
  //   menuOpen = false;
  // })

let accBtn = document.querySelector(".acc-btn");
let accMenu = document.querySelector('.acc-menu');

accBtn.addEventListener('click', function(){
  accMenu.classList.toggle('active-acc-menu');
});

