using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Utill;
using FA.JustBlog.Service.category;
using FA.JustBlog.Service.post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<UsingIdentityUser> _userManager;
        private readonly ILogger<PostController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly SignInManager<UsingIdentityUser> _signInManager;

        public HomeController(SignInManager<UsingIdentityUser> signInManager, ICategoryService categoryService, IPostService postService, ILogger<PostController> logger, UserManager<UsingIdentityUser> usermanager)
        {
            _postService = postService;
            _userManager = usermanager;
            _logger = logger;
            _categoryService = categoryService;
            _signInManager = signInManager;
        }

        // GET: HomeController
        [Authorize(Roles = $"{RoleUnit.Role_User}")]
        public ActionResult Index()
        {
            return View();
        }


        // POST: HomeController/Create
        [HttpPost]
        [Authorize(Roles = $"{RoleUnit.Role_User}")]
        public async Task<IActionResult> Create(string? checkConfirm)
        {
            if (checkConfirm == null)
            {
                return View("Index");
            }
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var roles = await _userManager.GetRolesAsync(user);

            if (!roles.Contains(RoleUnit.Role_Contributor))
            {
                await _userManager.AddToRoleAsync(user, RoleUnit.Role_Contributor);
            };
            await _userManager.RemoveFromRoleAsync(user, RoleUnit.Role_User);
            await _signInManager.SignOutAsync();
            await _signInManager.SignInAsync(user, isPersistent: false);
            return Redirect("/Admin/Post/");
        }


    }
}
