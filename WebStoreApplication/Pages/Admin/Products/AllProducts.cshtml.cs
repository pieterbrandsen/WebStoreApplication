using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Pages.Admin.Products
    {
    [Authorize(Roles = RoleNames.Admin)]
    public class AllProductsModel : PageModel
    {
#pragma warning disable IDE0052 // Remove unread private members
        private readonly IWebHostEnvironment _environment;
#pragma warning disable IDE0052 // Remove unread private members
        private readonly UserManager<IdentityUser> _userManager;
#pragma warning restore IDE0052 // Remove unread private members
        private readonly ApplicationDbContext _db;

        public List<ProductModel> productList = new List<ProductModel>();
        public AllProductsModel(IWebHostEnvironment environment,
                                UserManager<IdentityUser> userManager,
                                ApplicationDbContext db)
        {
            _environment = environment;
            _userManager = userManager;
            _db = db;
        }

        public class InputModel
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string Price { get; set; }
            public string Visible { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            productList = await _db.ProductModel.ToListAsync();
            productList.Sort((a, b) => { return a.Title.CompareTo(b.Title); });

            return Page();
        }
    }
}
