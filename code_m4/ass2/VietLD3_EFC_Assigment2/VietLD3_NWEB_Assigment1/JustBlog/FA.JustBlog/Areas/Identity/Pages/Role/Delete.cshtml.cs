﻿using FA.JustBlog.Core.Utill;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Areas.Identity.Pages.Role
{
    [Authorize(Roles = $"{RoleUnit.Role_BlogOwner}")]
    public class DeleteModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public DeleteModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public class InputModel
        {
            [Required]
            public string ID { set; get; }
            public string Name { set; get; }

        }
        [BindProperty]
        public InputModel Input { set; get; }

        [BindProperty]
        public bool isConfirmed { set; get; }

        [TempData] // Sử dụng Session
        public string StatusMessage { get; set; }

        public IActionResult OnGet() => NotFound("Not found");
        public async Task<IActionResult> OnPost()
        {
            var role = await _roleManager.FindByIdAsync(Input.ID);

            if (role == null)
            {
                return NotFound("Không thấy role cần xóa");
            }

            ModelState.Clear();
            await _roleManager.DeleteAsync(role);
            StatusMessage = "Đã xóa " + role.Name;

            return Redirect("/Admin/Role");
        }
    }
}
