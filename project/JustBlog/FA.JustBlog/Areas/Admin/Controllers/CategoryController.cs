using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Utill;
using FA.JustBlog.Service.category;
using FA.JustBlog.Service.post;
using FA.JustBlog.ViewModel.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{RoleUnit.Role_Contributor}, {RoleUnit.Role_BlogOwner}")]
    public class CategoryController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<UsingIdentityUser> _usermanager;
        private readonly ILogger<PostController> _logger;
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService, IPostService postService, ILogger<PostController> logger, UserManager<UsingIdentityUser> usermanager)
        {
            _postService = postService;
            _usermanager = usermanager;
            _logger = logger;
            _categoryService = categoryService;
        }

        // GET: CategoryController 
        public ActionResult Index()
        {
            var data = _categoryService.GetAll().DataList;
            return View(data);

        }

        // GET: CategoryController/Details/5 

        public ActionResult Details(int id)
        {
            var data = _categoryService.GetById(id).Data;
            return View(data);
        }

        // GET: CategoryController/Create
        [Authorize(Roles = $"{RoleUnit.Role_BlogOwner}")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [Authorize(Roles = $"{RoleUnit.Role_BlogOwner}")]
        public ActionResult Create(CategoryViewModel categoryViewModel)
        {
            try
            {
                _categoryService.Add(categoryViewModel);
            }
            catch
            {
            }
            return Redirect("/Admin/Category/Index");
        }

        // GET: CategoryController/Edit/5
        [Authorize(Roles = $"{RoleUnit.Role_BlogOwner}")]
        public ActionResult Edit(int id)
        {
            var data = _categoryService.GetById(id).Data;
            return View(data);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [Authorize(Roles = $"{RoleUnit.Role_BlogOwner}")]
        public ActionResult Edit(CategoryViewModel categoryViewModel)
        {
            try
            {
                _categoryService.Update(categoryViewModel);
            }
            catch
            {
            }
            return Redirect("/Admin/Category/Index");
        }

        // GET: CategoryController/Delete/5
        [Authorize(Roles = $"{RoleUnit.Role_BlogOwner}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _categoryService.Delete(id);
            }
            catch (Exception)
            {
            }
            return Redirect("/Admin/Category/Index");
        }

    }
}
