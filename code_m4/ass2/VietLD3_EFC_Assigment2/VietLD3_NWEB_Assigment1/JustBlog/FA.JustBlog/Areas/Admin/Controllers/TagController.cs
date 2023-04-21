using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Utill;
using FA.JustBlog.Service.post;
using FA.JustBlog.Service.tag;
using FA.JustBlog.ViewModel.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{RoleUnit.Role_Contributor}, {RoleUnit.Role_BlogOwner}")]
    public class TagController : Controller
    {

        private readonly IPostService _postService;
        private readonly UserManager<UsingIdentityUser> _usermanager;
        private readonly ILogger<PostController> _logger;
        private readonly ITagService _tagService;

        public TagController(ITagService tagService, IPostService postService, ILogger<PostController> logger, UserManager<UsingIdentityUser> usermanager)
        {
            _postService = postService;
            _usermanager = usermanager;
            _logger = logger;
            _tagService = tagService;
        }

        public ActionResult Index()
        {
            var data = _tagService.GetAll().DataList;
            return View(data);
        }

        // GET: TagController/Details/5
        public ActionResult Details(int id)
        {
            var data = _tagService.GetById(id).Data;
            return View(data);
        }

        // GET: TagController/Create 
        public ActionResult Create()
        {
            return View();
        }

        // POST: TagController/Create
        [HttpPost]
        public ActionResult Create(TagViewModel tagViewModel)
        {
            try
            {
                _tagService.Add(tagViewModel);
            }
            catch
            {
            }
            return Redirect("/Admin/Tag/Index");
        }

        // GET: TagController/Edit/5 
        public ActionResult Edit(int id)
        {
            var data = _tagService.GetById(id).Data;
            return View(data);
        }

        // POST: TagController/Edit/5
        [HttpPost]
        public ActionResult Edit(TagViewModel tagViewModel)
        {
            try
            {
                _tagService.Update(tagViewModel);
            }
            catch
            {
            }
            return Redirect("/Admin/Tag/Index");
        }

        // GET: TagController/Delete/5
        [Authorize(Roles = $"{RoleUnit.Role_BlogOwner}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _tagService.Delete(id);
            }
            catch (Exception)
            {
            }
            return Redirect("/Admin/Tag/Index");
        }

    }
}
