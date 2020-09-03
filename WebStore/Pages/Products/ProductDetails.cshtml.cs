using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Pages.Products
{
    public class ProductDetailsModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;

        public ProductDetailsModel(IWebHostEnvironment environment,
                                UserManager<IdentityUser> userManager,
                                ApplicationDbContext db)
        {
            _environment = environment;
            _userManager = userManager;
            _db = db;
        }

        public ProductModel product;

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            public ProductModel ProductModel { get; set; }
        }

        public IActionResult OnGet(string Id)
        {
            Input = new InputModel
            {
                ProductModel = _db.ProductModel.FirstOrDefault(p => p.Id == Id)
            };

            return Page();
        }
    }
}
