using FA.JustBlog.Service.post;
using FA.JustBlog.Service.tag;
using FA.JustBlog.ViewModel.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly ITagService _tagService;

        public PostController(IPostService postService, ITagService tagService)
        {
            _postService = postService;
            _tagService = tagService;
        }


        // GET: PostController
        public ActionResult Index(string? tag, string? category)
        {
            IList<PostViewModel> listPost = _postService.GetAll(tag, category).DataList;
            ViewBag.MostViews = _postService.GetMostView(tag, category).DataList;
            ViewBag.LastPosts = listPost.Take(5).ToList();
            ViewBag.Tags = _tagService.GetAll().DataList;
            return View(listPost);
        }

        // GET: PostController/Details/5
        public ActionResult Details(string post)
        {
            PostViewModel postViewModel = _postService.GetByUrl(post).Data ?? new PostViewModel();

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
