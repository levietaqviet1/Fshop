using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Utill;
using FA.JustBlog.Service.comment;
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
    public class CommentController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<UsingIdentityUser> _usermanager;
        private readonly ILogger<PostController> _logger;
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService, IPostService postService, ILogger<PostController> logger, UserManager<UsingIdentityUser> usermanager)
        {
            _postService = postService;
            _usermanager = usermanager;
            _logger = logger;
            _commentService = commentService;
        }

        // GET: CommentController
        public ActionResult Index()
        {
            var data = _commentService.GetAll().DataList;
            return View(data);
        }

        // GET: CommentController/Details/5
        public ActionResult Details(int id)
        {
            var data = _commentService.GetById(id).Data;
            return View(data);
        }

        // GET: CommentController/Create
        [Authorize(Roles = $"{RoleUnit.Role_Contributor}, {RoleUnit.Role_BlogOwner}")]
        public ActionResult Create()
        {
            ViewBag.PostList = _postService.GetAll(null, null).DataList;
            return View();
        }

        // POST: CommentController/Create
        [HttpPost]
        [Authorize(Roles = $"{RoleUnit.Role_Contributor}, {RoleUnit.Role_BlogOwner}")]
        public ActionResult Create(CommentViewModel commentViewModel)
        {
            try
            {
                commentViewModel.UsingIdentityUserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                _commentService.Add(commentViewModel);
            }
            catch
            {

            }
            return Redirect("/Admin/Comment/Index");
        }

        // GET: CommentController/Edit/5
        [Authorize(Roles = $"{RoleUnit.Role_Contributor}, {RoleUnit.Role_BlogOwner}")]
        public ActionResult Edit(int id)
        {
            ViewBag.PostList = _postService.GetAll(null, null).DataList;
            var data = _commentService.GetById(id).Data;
            return View(data);
        }

        // POST: CommentController/Edit/5
        [HttpPost]
        [Authorize(Roles = $"{RoleUnit.Role_Contributor}, {RoleUnit.Role_BlogOwner}")]
        public ActionResult Edit(CommentViewModel commentViewModel)
        {
            try
            {
                _commentService.Update(commentViewModel);
            }
            catch
            {

            }
            return Redirect("/Admin/Comment/Index");
        }

        // GET: CommentController/Delete/5
        [Authorize(Roles = $"{RoleUnit.Role_BlogOwner}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _commentService.Delete(id);
            }
            catch (Exception)
            {
            }
            return Redirect("/Admin/Comment/Index");
        }


    }
}
