const contentsForm = document.getElementById('contents-form');

const loadForm = document.getElementById('loading');


document.getElementById('forms-content').addEventListener('click', (event) =>{
  event.preventDefault();

  contentsForm.classList.add('visually-hidden');
  loadForm.classList.remove('visually-hidden');

  setTimeout(() => {
    loadForm.classList.add('visually-hidden');
    contentsForm.classList.remove('visually-hidden');
  }, 5000);
})


document.getElementById('views-content').addEventListener('click', (event) =>{
  event.preventDefault();

  contentsForm.classList.add('visually-hidden');
  loadForm.classList.remove('visually-hidden');

  setTimeout(() => {
    window.location.assign('viewcontent.html');
  }, 5000);
})

