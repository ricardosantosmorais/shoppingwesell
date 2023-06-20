/********* Evento para ativar o carrossel *****************/
jQuery(document).ready(function(){
		jQuery('.bxslider').bxSlider({
			auto: true,
			minSlides: 3,
			maxSlides: 3,
			slideWidth: 300,
			nextSelector: '#slider-next',
			prevSelector: '#slider-prev',
			pager: false,
			captions: false
	});
});