"use strict"

/********** Initialize Swiper ***********/
var swiper = new Swiper(".swiper-main", {
	grabCursor: true,
	centeredSlides: true,
	slidesPerView: 1,
	spaceBetween: 100,
	centeredSlides: true,

	pagination: {
		el: '#swiper-pagination',
		clickable: true,
	},
});