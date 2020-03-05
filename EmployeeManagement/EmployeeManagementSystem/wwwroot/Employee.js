function validate() {
    var fname = $('#fname').val();
    var lname = $('#lname').val();
    var email = $('#email').val();
    var password = $('#password').val();

    if (fname.length < 1) {
        $('#fname').after('<span class="error">This field is required</span>');
    }
    if (lname.length < 1) {
        $('#lname').after('<span class="error">This field is required</span>');
    }
    if (email.length < 1) {
        $('#email').after('<span class="error">This field is required</span>');
    }
}
function EmailValidation(){
        var regex = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
        if (regex.test(email) == false) {
            alert('Invalid Email Address');
            return false;
        }
        else {
            return true;
        }
    }
    if (password.length < 8) {
        $('#password').after('<span class="error">Password must be at least 8 characters long</span>');
    }
