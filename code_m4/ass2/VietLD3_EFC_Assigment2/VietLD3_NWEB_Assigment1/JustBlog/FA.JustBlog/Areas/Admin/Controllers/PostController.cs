using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Utill;
using FA.JustBlog.Service.category;
using FA.JustBlog.Service.post;
using FA.JustBlog.ViewModel.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{RoleUnit.Role_Contributor}, {RoleUnit.Role_BlogOwner}")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<UsingIdentityUser> _usermanager;
        private readonly ILogger<PostController> _logger;
        private readonly ICategoryService _categoryService;

        public PostController(ICategoryService categoryService, IPostService postService, ILogger<PostController> logger, UserManager<UsingIdentityUser> usermanager)
        {
            _postService = postService;
            _usermanager = usermanager;
            _logger = logger;
            _categoryService = categoryService;
        }

        // GET: PostController

        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var listPosts = _postService.GetAll(null, null).DataList;
            if (User.Claims.Any(c => c.Type == ClaimTypes.Role && (c.Value == $"{RoleUnit.Role_BlogOwner}")))
            {
                return View(listPosts);
            }
            listPosts = listPosts.Where(x => x.UsingIdentityUserId == userId).ToList();
            return View(listPosts);
        }

        [Authorize(Roles = $"{RoleUnit.Role_Contributor}, {RoleUnit.Role_BlogOwner}")]
        // GET: PostController/Create 
        public ActionResult Create()
        {
            ViewBag.CateList = _categoryService.GetAll().DataList;

            return View();
        }

        // POST: PostController/Create
        [HttpPost]
        public ActionResult Create(PostViewModel postViewModel)
        {
            try
            {
                postViewModel.UrlSlug = Utils.ConFigUrlSlug(postViewModel.Title);
                var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                postViewModel.UsingIdentityUserId = userId;
                _postService.Add(postViewModel);
                return Redirect($"/post/Details?post={postViewModel.Id}");
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Edit/5 
        public ActionResult Edit(int id)
        {
            var post = _postService.GetById(id).Data;
            ViewBag.CateList = _categoryService.GetAll().DataList;
            return View(post);
        }

        // POST: PostController/Edit/5 
        [HttpPost]
        public ActionResult Edit(PostViewModel postViewModel)
        {
            try
            {
                postViewModel.UrlSlug = Utils.ConFigUrlSlug(postViewModel.Title);
                _postService.Update(postViewModel);

            }
            catch
            {

            }

            return Redirect($"/post/Details?post={postViewModel.UrlSlug}");
        }

        // GET: PostController/Delete/5 
        public ActionResult Delete(int id)
        {
            try
            {
                _postService.Delete(id);
            }
            catch (Exception)
            {
            }

            return Redirect("/Admin/Post/Index");
        }
    }
}
