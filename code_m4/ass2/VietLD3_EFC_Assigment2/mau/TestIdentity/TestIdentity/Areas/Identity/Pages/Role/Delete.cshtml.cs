﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TestIdentity.Areas.Identity.Pages.Role
{
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
            public string Id { set; get; }
            public string Name { set; get; }

        }
        [BindProperty]
        public InputModel Input { set; get; }

        [BindProperty]
        public bool isConfirmed { set; get; }

        [TempData] // Sử dụng Session
        public string StatusMessage { get; set; }
        public IActionResult OnGet() => NotFound("Không thấy");
        
        public async Task<IActionResult> OnPost()
        {
            var role = await _roleManager.FindByIdAsync(Input.Id);

            if (role == null)
            {
                return NotFound("Không thấy role cần xóa");
            }

            ModelState.Clear();

            if (isConfirmed)
            {
                //Xóa
                await _roleManager.DeleteAsync(role);
                StatusMessage = "Đã xóa " + role.Name;

                return RedirectToPage("Index");
            }
            else
            {
                Input.Name = role.Name;
                isConfirmed = true;

            }

            return Page();
        }
    }
}

