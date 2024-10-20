using FashionStore.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace App.Admin.Role
{
    public class IndexModel : RolePageModel
    {
        public IndexModel(RoleManager<IdentityRole> roleManager, FosDbContext fosDbContext) : base(roleManager, fosDbContext)
        {
        }

        public List<IdentityRole> Roles { get; set; }

        public async Task OnGet()
        {
            Roles = await _roleManager.Roles.ToListAsync();
        }

        public void OnPost() => RedirectToPage();
    }
}
