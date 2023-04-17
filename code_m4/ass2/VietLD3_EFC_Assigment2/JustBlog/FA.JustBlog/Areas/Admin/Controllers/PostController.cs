using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Utill;
using FA.JustBlog.Service.post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<UsingIdentityUser> _usermanager;
        private readonly ILogger<PostController> _logger;

        public PostController(IPostService postService, ILogger<PostController> logger, UserManager<UsingIdentityUser> usermanager)
        {
            _postService = postService;
            _usermanager = usermanager;
            _logger = logger;
        }

        // GET: PostController
        [Authorize(Roles = $"{RoleUnit.Role_Contributor}, {RoleUnit.Role_BlogOwner}")]
        public async Task<IActionResult> Index()
        {
            var listPosts = _postService.GetAll(null, null).DataList;
            return View(listPosts);
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [Authorize(Roles = $"{RoleUnit.Role_Contributor}, {RoleUnit.Role_BlogOwner}")]
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
