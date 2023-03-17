const form = document.getElementById('form');
const emailRegex =/^[^\s@]+@[^\s@]+\.[^\s@]+$/;


const emailInput = document.getElementById('emailInput');
const passInput = document.getElementById('passInput');
const cbInput = document.getElementById('cbInput');

const errorEmail = document.getElementById('errorEmail');
const errorPass = document.getElementById('errorPassword');

let checkEmail = true;
let checkPassword = true;
let checkCb = true;

function emailOnClick() {
    if (emailInput.value != null || emailInput.value != '') {
        errorEmail.innerText = "";
        checkEmail = true;
    }
}

function passwordOnClick() {
    if (passInput.value != null || passInput.value != '') {
        errorPass.innerText = "";
        checkPassword = true;
    }
}

form.addEventListener('submit', function(event){
    event.preventDefault();

    if (emailInput.value == "" || emailInput.value == null) {
        errorEmail.innerText = "Email is required";
        checkEmail = false;
    }
    else if (emailInput.value.length < 5 || emailInput.value.length >50){
        errorEmail.innerText = "Email must be greater than 5 and smaller than 50 characters!";
        checkEmail = false;
    }    
    // else if (!emailInput.match(emailRegex)){
    //     errorEmail.innerText = "Email is vaild";
    //     checkEmail = false;
    // }
     else {
        errorEmail.innerText = "";
        checkEmail = true;
    }

    if (passInput.value == "" || passInput.value == null) {

        errorPass.innerText = "Password is required";
        checkPassword = false;
    } else if (passInput.value.length < 8 || passInput.value.length > 30) {
        errorPass.innerText = "Password must be at least 8 and smaller than 30 characters!";
        checkPassword = false;
    }
    else {
        errorPass.innerText = "";
        checkPassword = true;
    }
    if(checkEmail && checkPassword) { 
        window.location.assign("viewcontent.html");
    }
});