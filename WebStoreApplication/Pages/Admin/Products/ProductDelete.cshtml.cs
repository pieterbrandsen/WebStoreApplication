using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Pages.Admin.Products
{
    [Authorize(Roles = RoleNames.Admin)]
    public class ProductDeleteModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;

        public ProductDeleteModel(IWebHostEnvironment environment,
                                UserManager<IdentityUser> userManager,
                                ApplicationDbContext db)
        {
            _environment = environment;
            _userManager = userManager;
            _db = db;
        }


        public IActionResult OnGet(string Id)
        {
            ProductModel product = _db.ProductModel.FirstOrDefault(p => p.Id == Id);
             _db.ProductModel.Remove(product);
            _db.SaveChanges();
            return Page();
        }
    }
}
