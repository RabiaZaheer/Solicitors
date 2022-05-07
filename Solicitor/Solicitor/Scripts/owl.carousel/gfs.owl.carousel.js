$(document).ready(function () {
	$('.owl-carousel').owlCarousel({
		animateIn: 'slideInRight',
		items: 1,
		smartSpeed: 450,
		loop: true,
		nav: false,
		dots: true,
		margin: 0,
		autoplay: true,
		autoplayTimeout: 5000,
		autoplayHoverPause: true,
		responsiveClass: true
	});
});