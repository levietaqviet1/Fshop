using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Utill;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Areas.Identity.Pages.Role
{
    [Authorize(Roles = $"{RoleUnit.Role_BlogOwner}")]

    public class AddUserRole : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<UsingIdentityUser> _userManager;
        public AddUserRole(RoleManager<IdentityRole> roleManager,
                       UserManager<UsingIdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public class InputModel
        {
            [Required]
            public string ID { set; get; }
            public string Name { set; get; }

            public string[] RoleNames { set; get; }

            public UsingIdentityUser User { set; get; }

        }
        [BindProperty]
        public InputModel Input { set; get; }

        [BindProperty]
        public bool isConfirmed { set; get; }

        [TempData] // Sử dụng Session
        public string StatusMessage { get; set; }

        public IActionResult OnGet()
        {
            return Redirect("/Admin/User");
        }

        public List<string> AllRoles { set; get; } = new List<string>();
        public async Task<IActionResult> OnPost(bool IsDelete = false)
        {

            var user = await _userManager.FindByIdAsync(Input.ID);
            if (user == null)
            {
                return NotFound("Không thấy role");
            }

            var roles = await _userManager.GetRolesAsync(user);
            var allroles = await _roleManager.Roles.ToListAsync();

            allroles.ForEach((r) =>
            {
                AllRoles.Add(r.Name);
            });

            if (IsDelete)
            {
                await _userManager.DeleteAsync(user);
                return Redirect("/Admin/User");
            }

            if (!isConfirmed)
            {
                Input.RoleNames = roles.ToArray();
                isConfirmed = true;
                StatusMessage = "";
                ModelState.Clear();
                try
                {
                    Input.User = (UsingIdentityUser)user;
                }
                catch (Exception ex)
                {
                }
            }

            else
            {
                // Update add and remove
                StatusMessage = "Vừa cập nhật";
                if (Input.RoleNames == null) Input.RoleNames = new string[] { };
                foreach (var rolename in Input.RoleNames)
                {
                    if (roles.Contains(rolename)) continue;
                    await _userManager.AddToRoleAsync(user, rolename);
                }
                foreach (var rolename in roles)
                {
                    if (Input.RoleNames.Contains(rolename)) continue;
                    await _userManager.RemoveFromRoleAsync(user, rolename);
                }
                user.UserName = Input.User.UserName;
                user.Firstname = Input.User.Firstname;
                user.LastName = Input.User.LastName;
                user.PhoneNumber = Input.User.PhoneNumber;
                user.TwoFactorEnabled = Input.User.TwoFactorEnabled;
                user.LockoutEnabled = Input.User.LockoutEnabled;
                _userManager.UpdateAsync(user);
                return Redirect("/Admin/User");

            }

            Input.Name = user.UserName;
            return Page();
        }
    }
}
