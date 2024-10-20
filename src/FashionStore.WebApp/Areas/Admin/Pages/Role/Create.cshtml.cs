using FashionStore.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace App.Admin.Role
{
    public class CreateModel : RolePageModel
    {
        public CreateModel(RoleManager<IdentityRole> roleManager, FosDbContext fosDbContext) : base(roleManager, fosDbContext)
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


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var newRole = new IdentityRole(Input.Name);
            var result = await _roleManager.CreateAsync(newRole);
            if (result.Succeeded)
            {
                StatusMessage = $"You have successfully created a new role: {Input.Name}";
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
