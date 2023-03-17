const contents = document.getElementById('contents-editor');
const load = document.getElementById('loading');
const viewsContent = document.getElementById('views-content');
const formsContent = document.getElementById('forms-content');

viewsContent.addEventListener('click', (event) => {
  event.preventDefault();
  contents.classList.add('visually-hidden');
  load.classList.remove('visually-hidden');

  setTimeout(() => {
    window.location.assign('viewcontent.html');
  }, 5000);
})

formsContent.addEventListener('click', (event) => {
  event.preventDefault();
  contents.classList.add('visually-hidden');
  load.classList.remove('visually-hidden');

  setTimeout(() => {
    window.location.assign('formcontent.html');
  }, 5000);
})

const inputFirstName = document.getElementById('firstname');
const inputLastName = document.getElementById('lastname');
const inputPhone = document.getElementById('phone');
const inputDesc = document.getElementById('description');

const inputs = { 'firstname': '', 'lastname': '', 'phone': '', 'description': '' };

function setInputValue(key, value) {
  inputs[key] = value;
  sessionStorage.setItem('inputs', JSON.stringify(inputs));
}

function getInputValue(key) {
  const savedInputs = JSON.parse(sessionStorage.getItem('inputs'));
  return savedInputs ? savedInputs[key] : '';
}

inputFirstName.addEventListener('input', function () {
  setInputValue('firstname', inputFirstName.value);
});

inputLastName.addEventListener('input', function () {
  setInputValue('lastname', inputLastName.value);
});

inputPhone.addEventListener('input', function () {
  setInputValue('phone', inputPhone.value);
});

inputDesc.addEventListener('input', function () {
  setInputValue('description', inputDesc.value);
});

window.addEventListener('load', function () {
  inputFirstName.value = getInputValue('firstname');
  inputLastName.value = getInputValue('lastname');
  inputPhone.value = getInputValue('phone');
  inputDesc.value = getInputValue('description');
});

const errorFirstName = document.getElementById('errorFirstName');
const errorLastName = document.getElementById('errorLastName');
const errorPhone = document.getElementById('errorPhone');
const errorDesc = document.getElementById('errorDesc');

function resetErrorText(element) {
  element.innerText = '';
}

function validateInputLength(inputElement, errorElement, minLength, maxLength, errorMessage) {
  const inputValue = inputElement.value.trim();
  if (!inputValue) {
    errorElement.innerText = 'Vui lòng nhập giá trị';
  } else if (inputValue.length < minLength || inputValue.length > maxLength) {
    errorElement.innerText = errorMessage;
  } else {
    errorElement.innerText = '';
  }
}

function validatePhone(inputElement, errorElement) {
  const inputValue = inputElement.value.trim();
  if (!inputValue) {
    errorElement.innerText = 'Vui lòng nhập giá trị';
  } else if (!/^\d{9,13}$/.test(inputValue)) {
    errorElement.innerText = 'Số điện thoại không hợp lệ';
  } else {
    errorElement.innerText = '';
  }
}

form.addEventListener('submit', function (event) {
  event.preventDefault();

  resetErrorText(errorFirstName);
  resetErrorText(errorLastName);
  resetErrorText(errorPhone);
  resetErrorText(errorDesc);

  validateInputLength(inputFirstName, errorFirstName, 3, 30, 'Họ tên phải từ 3 đến 30 ký tự!');
  validateInputLength(inputLastName, errorLastName, 3, 30, 'Tên phải từ 3 3 đến 30 ký tự!');
  validatePhone(inputPhone, errorPhone);
  
})
