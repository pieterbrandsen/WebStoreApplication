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
    public class ProductPage : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;

        public ProductPage(IWebHostEnvironment environment,
                                UserManager<IdentityUser> userManager,
                                ApplicationDbContext db)
        {
            _environment = environment;
            _userManager = userManager;
            _db = db;
        }

        public ProductModel Product;
        public string[] DescriptionList;
        public string[] AdditionalInformationList;

        public IActionResult OnGet(string Title)
        {
            Product = _db.ProductModel.FirstOrDefault(p => p.Title == Title);
            DescriptionList = Product.Description.Split("<br>");
            AdditionalInformationList = Product.AdditionalInformation.Split("<br>");

            return Page();
        }
    }
}
