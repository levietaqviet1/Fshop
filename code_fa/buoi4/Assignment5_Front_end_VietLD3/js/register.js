const form = document.getElementById('form');
const registered = document.getElementById('registered');
const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

const username = document.getElementById('username');
const email = document.getElementById('email');
const passwords = document.getElementById('passwords');
const rePassword = document.getElementById('rePassword');

const errorUsername = document.getElementById('errorUsername');
const errorEmail = document.getElementById('errorEmail');
const errorPassword = document.getElementById('errorPassword');
const errorRePassword = document.getElementById('errorRePassword');

let checkSame = true;
let checkUser = true;
let checkEmail = true;
let checkPassword = true;
let checkRePassword = true;

function userOnClick() {
        errorUsername.innerText = "";
}

function emailOnClick() {
        errorEmail.innerText = "";
}

function passwordOnClick() {
        errorPassword.innerText = "";
}

function rePasswordOnClick() {
        errorRePassword.innerText = "";
}

form.addEventListener('submit', function (event) {
    event.preventDefault();

    if (username.value == null || username.value == "") {
        errorUsername.innerText = "Username is required";
        checkUser = false;
    } else if (username.value.length < 3 || username.value.length > 30) {
        errorUsername.innerText = "Username must be greater than 3 and smaller than 30 characters !";
        checkUser = false;
    }
    else {
        errorUsername.innerText = "";
        checkUser = true;
    }

    if (email.value == "" || email.value == null) {
        errorEmail.innerText = "Email is required";
        checkEmail = false;
    }
    else if (email.value.length < 5 || email.value.length >50){
        errorEmail.innerText = "Email must be greater than 5 and smaller than 50 characters!";
        checkEmail = false;
    }    
    // else if (!email.test(emailRegex)){
    //     errorEmail.innerText = "Email is vaild";
    //     checkEmail = false;
    // }
     else {
        errorEmail.innerText = "";
        checkEmail = true;
    }

    if (passwords.value == "" || passwords.value == null) {

        errorPassword.innerText = "Password is required";
        checkPassword = false;
    } else if (passwords.value.length < 8 || passwords.value.length > 30) {
        errorPassword.innerText = "Password must be at least 8 and smaller than 30 characters!";
        checkPassword = false;
    }
    else {
        errorPassword.innerText = "";
        checkPassword = true;
    }

    if (rePassword.value == "" || rePassword.value == null) {
        errorRePassword.innerText = "Confirm password is required";
        checkRePassword = false;
    } else if (rePassword.value.length < 8 || rePassword.value.length > 30) {
        errorPassword.innerText = "Re-Password must be at least 8 and smaller than 30 characters!";
        checkRePassword = false;
    }
    else {
        errorRePassword.innerText = "";
        checkRePassword = true;
    }

    if (passwords.value !== rePassword.value) {
        errorRePassword.innerText = "Password and Confirm Password do not match";
        checkSame = false;
    } else {
        errorRePassword.innerText = ""
        checkSame = true;
    }

    if(checkUser && checkEmail && checkPassword && checkRePassword && checkSame) { 
        registered.classList.remove("text-white")
        registered.classList.add("text-success")
        setTimeout(() => {
            window.location.assign('login.html');
          }, 2000);
    }
});