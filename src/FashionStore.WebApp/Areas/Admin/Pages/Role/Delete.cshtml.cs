using FashionStore.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace App.Admin.Role
{
    public class DeleteModel : RolePageModel
    {
        public DeleteModel(RoleManager<IdentityRole> roleManager, FosDbContext fosDbContext) : base(roleManager, fosDbContext)
        {
        }

        public IdentityRole Role { get; set; }

        public async Task<IActionResult> OnGet(string roleId)
        {
            if (roleId == null) return NotFound("Role not found");

            Role = await _roleManager.FindByIdAsync(roleId);
            if (Role == null)
            {
                return NotFound("Role not found");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string roleId)
        {
            if (roleId == null) return NotFound("Role not found");
            Role = await _roleManager.FindByIdAsync(roleId);
            if (Role == null) return NotFound("Role not found");

            var result = await _roleManager.DeleteAsync(Role);
            if (result.Succeeded)
            {
                StatusMessage = $"You have successfully deleted role: {Role.Name}";
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
