using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Areas.Identity.Pages.User
{
    [Authorize]
    public class UserModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<UsingIdentityUser> _userManager;

        public UserModel(RoleManager<IdentityRole> roleManager,
                           UserManager<UsingIdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;

        }
        public class UserInList : UsingIdentityUser
        {
            // Liệt kê các Role của User ví dụ: "Admin,Editor" ...
            public string listroles { set; get; }
        }
        public List<UserInList> users;
        public int totalPages { set; get; }

        [TempData] // Sử dụng Session
        public string StatusMessage { get; set; }
        [BindProperty(SupportsGet = true)]
        public int pageNumber { set; get; }
        public IActionResult OnPost() => NotFound("Cấm post");

        public async Task<IActionResult> OnGet()
        {

            //var cuser = await _userManager.GetUserAsync(User);
            //await _userManager.AddToRolesAsync(cuser, new string[] { "Editor" });

            if (pageNumber == 0)
                pageNumber = 1;

            var listUsers = from u in _userManager.Users
                            orderby u.UserName
                            select new UserInList()
                            {
                                Id = u.Id,
                                UserName = u.UserName,
                                Firstname = u.Firstname,
                                LastName = u.LastName,
                                Email = u.Email,
                                PhoneNumber = u.PhoneNumber,
                                EmailConfirmed = u.EmailConfirmed,
                                PhoneNumberConfirmed = u.PhoneNumberConfirmed
                            };


            users = await listUsers.ToListAsync();

            // users.ForEach(async (user) => {
            //     var roles = await _userManager.GetRolesAsync(user);
            //     user.listroles = string.Join(",", roles.ToList());
            // });

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                user.listroles = string.Join(", ", roles.ToList());
            }

            return Page();
        }
    }
}
