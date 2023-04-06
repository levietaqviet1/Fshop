﻿using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Areas.Identity.Pages.Role
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
            for (int i = 0; i < 100; i++)
            {
                await _userManager.CreateAsync(new UsingIdentityUser { Firstname = "ffewfedvev" + i, LastName = "lfefefefef" + i, UserName = "useras" + i, Email = "userafefe" + i + "@gmail.com" }, "1addcA2345678954851");
            }
            if (pageNumber == 0)
                pageNumber = 1;

            var listUsers = (from u in _userManager.Users
                             orderby u.UserName
                             select new UserInList()
                             {
                                 Id = u.Id,
                                 UserName = u.UserName,
                             });


            int totalUsers = await listUsers.CountAsync();


            totalPages = (int)Math.Ceiling((double)totalUsers / USER_PER_PAGE);

            users = await listUsers.Skip(USER_PER_PAGE * (pageNumber - 1)).Take(USER_PER_PAGE).ToListAsync();

            // users.ForEach(async (user) => {
            //     var roles = await _userManager.GetRolesAsync(user);
            //     user.listroles = string.Join(",", roles.ToList());
            // });

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                user.listroles = string.Join(",", roles.ToList());
            }

            return Page();
        }
    }
}
