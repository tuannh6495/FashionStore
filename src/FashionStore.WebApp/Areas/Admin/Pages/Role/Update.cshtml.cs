using FashionStore.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace App.Admin.Role
{
    public class UpdateModel : RolePageModel
    {
        public UpdateModel(RoleManager<IdentityRole> roleManager, FosDbContext fosDbContext) : base(roleManager, fosDbContext)
        {
        }

        public class InputModel
        {
            [Display(Name = "Role name")]
            [Required(ErrorMessage = "Please enter your role name")]
            [StringLength(256, MinimumLength = 3, ErrorMessage = "{0} must be at least {2} characters long")]
            public string Name { get; set; }
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IdentityRole Role { get; set; }


        public async Task<IActionResult> OnGet(string roleId)
        {
            if (roleId == null) return NotFound("Role not found");

            Role = await _roleManager.FindByIdAsync(roleId);
            if (Role != null)
            {
                Input = new InputModel()
                {
                    Name = Role.Name
                };
                return Page();
            }
            return NotFound("Role not found");
        }

        public async Task<IActionResult> OnPostAsync(string roleId)
        {
            if (roleId == null) return NotFound("Role not found");
            Role = await _roleManager.FindByIdAsync(roleId);
            if (Role == null) return NotFound("Role not found");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            Role.Name = Input.Name;
            var result = await _roleManager.UpdateAsync(Role);
            if (result.Succeeded)
            {
                StatusMessage = $"You have successfully updated role: {Input.Name}";
                return RedirectToPage("./Index");
            }
            else
            {
                result.Errors.ToList().ForEach(error =>
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                });
            }
            return Page();

        }
    }
}
