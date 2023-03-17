const contents = document.getElementById('contents-view');

const load = document.getElementById('loading');


document.getElementById('view-content').addEventListener('click', (event) =>{
  event.preventDefault();

  contents.classList.add('visually-hidden');
  load.classList.remove('visually-hidden');
  
  setTimeout(() => {
    load.classList.add('visually-hidden');
    contents.classList.remove('visually-hidden');
  }, 5000);
})


document.getElementById('forms-content').addEventListener('click', (event) =>{
  event.preventDefault();

  contents.classList.add('visually-hidden');
  load.classList.remove('visually-hidden');

  setTimeout(() => {
    window.location.assign('formcontent.html');
  }, 5000);
})