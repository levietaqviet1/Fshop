﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestIdentity.Areas.Identity.Data;

namespace TestIdentity.Areas.Identity.Pages.Role
{
    public class UserModel : PageModel
    {
        const int USER_PER_PAGE = 10;

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<UsingIdentityUser> _userManager;

        public UserModel(RoleManager<IdentityRole> roleManager,
            UserManager<UsingIdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;

        }

        public class UserInRole : UsingIdentityUser
        {
            public string ListRoles { get; set; }
        }

        public List<UserInRole> users;
        public int TotalPage { get; set; }

        [TempData] // Sử dụng Session
        public string StatusMessage { get; set; }

        [BindProperty(SupportsGet = true)]
        public int pageNumber { set; get; }

        public void OnPost() => NotFound("Not found!");
        public async Task<IActionResult> OnGet()
        {
            if (pageNumber == 0) pageNumber = 1;

            var listUsers = _userManager.Users
                .OrderBy(u => u.UserName)
                .Select(u =>
                new UserInRole() 
                { 
                    Id = u.Id, 
                    UserName = u.UserName,
                    FirstName=u.FirstName,
                    LastName=u.LastName 
                });

            int totalUsers = await listUsers.CountAsync();

            TotalPage = (int)Math.Ceiling(totalUsers * 1.0 / USER_PER_PAGE);

            users = await listUsers
                .Skip(USER_PER_PAGE * (pageNumber - 1))
                .Take(USER_PER_PAGE)
                .ToListAsync();

            //getRoles for each user
            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                user.ListRoles = string.Join(",", roles.ToList());
            }

            return Page();
        }
    }
}
