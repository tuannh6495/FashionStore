using FashionStore.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Admin.Role
{
    public class RolePageModel : PageModel 
    {
        protected readonly RoleManager<IdentityRole> _roleManager;
        protected readonly FosDbContext _context;

        [TempData]
        public string StatusMessage { get; set; }

        public RolePageModel(RoleManager<IdentityRole> roleManager, FosDbContext fosDbContext)
        {
            _roleManager = roleManager;
            _context = fosDbContext;
        }
    }
}