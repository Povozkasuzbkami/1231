"use strict"

document.querySelectorAll('.nav-link').forEach(item => {
    $(item)[0].addEventListener('mouseenter', function (event) {
        $(event.target).parent().find('.block__dropdown').stop(true).slideDown(200);
        $('.block-blur')[0].style.display = 'block';
    })
    $(item).parent()[0].addEventListener('mouseleave', function (event) {
        $(event.target).find('.block__dropdown').stop(true).slideUp(200);
        $('.block-blur')[0].style.display = 'none';
    })
});


$('#accept')[0].addEventListener('change', (event) => {
    console.log($('#accept')[0]);
    console.log($('#accept')[0].checked);
    if ($('#accept')[0].checked) {
        $('#button-resume')[0].removeAttribute('disabled');
    }
    else {
        $('#button-resume')[0].setAttribute('disabled', '');
    }
});