
(function ($) {
    "use strict";

    
    /*==================================================================
    [ Validate ]*/
    var input = $('.validate-input .input100');

    $('.validate-form').on('submit',function(){
        var check = true;

        for(var i=0; i<input.length; i++) {
            if(validate(input[i]) == false){
                showValidate(input[i]);
                check=false;
            }
        }

        return check;
    });


    $('.validate-form .input100').each(function(){
        $(this).focus(function(){
           hideValidate(this);
        });
    });

    function validate (input) {
        if($(input).attr('type') == 'text' && $(input).attr('name') == 'Email') {
            if($(input).val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) == null) {
                return false;
            }
        }
        else if ($(input).attr('type') == 'password' && $(input).attr('name') == 'Password') {
            var elementValue = $(input).val().trim();
            if (elementValue == '' || elementValue.length < 6) {
                return false;
            }
        }
        else if ($(input).attr('id') == 'cPass') {
            var elementValue = $(input).val().trim();
            if (elementValue == '' || elementValue.length < 6) {
                return false;
            }
        }
        else if ($(input).attr('id') == 'fnam') {
            var elementValue = $(input).val().trim();
            if (elementValue == '') {
                return false;
            }
        }
        else if ($(input).attr('id') == 'lnam') {
            var elementValue = $(input).val().trim();
            if (elementValue == '') {
                return false;
            }
        }
        return true;
    }

    function showValidate(input) {
        var thisAlert = $(input).parent();

        $(thisAlert).addClass('alert-validate');
    }

    function hideValidate(input) {
        var thisAlert = $(input).parent();

        $(thisAlert).removeClass('alert-validate');
    }
    
    

})(jQuery);