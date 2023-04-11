using FA.JustBlog.Service.post;
using FA.JustBlog.ViewModel.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }


        // GET: PostController
        public ActionResult Index()
        {
            IList<PostViewModel> listPost = _postService.GetAll().DataList;
            ViewBag.MostViews = _postService.GetMostView().DataList;
            ViewBag.LastPosts = _postService.GetAll().DataList.Take(5).ToList();
            return View(listPost);
        }

        // GET: PostController/Details/5
        public ActionResult Details(string urlSlug)
        {
            PostViewModel postViewModel = _postService.GetByUrl(urlSlug).Data;
            return View(postViewModel);
        }

        // GET: PostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
