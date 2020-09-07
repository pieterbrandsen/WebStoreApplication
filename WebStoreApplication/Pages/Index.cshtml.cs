using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;
        public IndexPageModel IndexPage;
        private ProductModel Product;
        public List<ProductModel> TopProductList = new List<ProductModel>();
        public List<ProductModel> TrendingProductList = new List<ProductModel>();

        public IndexModel(UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult OnGet()
        {
            string pagePath = HttpContext.Request.Path.ToString();
            

            if (pagePath == "/")
            {
                IndexPage = (IndexPageModel)_db.PageModel.FirstOrDefault(p => p.PageModelName == PageModelNamesClass.IndexPageModel);

                Product = _db.ProductModel.FirstOrDefault(p => p.Title == IndexPage.TopProductName1);
                if (Product != null)
                {
                    TopProductList.Add(Product);
                }
                Product = _db.ProductModel.FirstOrDefault(p => p.Title == IndexPage.TopProductName2);
                if (Product != null)
                {
                    TopProductList.Add(Product);
                }
                Product = _db.ProductModel.FirstOrDefault(p => p.Title == IndexPage.TopProductName3);
                if (Product != null)
                {
                    TopProductList.Add(Product);
                }

                Product = _db.ProductModel.FirstOrDefault(p => p.Title == IndexPage.TrendingProductName1);
                if (Product != null)
                {
                    TrendingProductList.Add(Product);
                }
                Product = _db.ProductModel.FirstOrDefault(p => p.Title == IndexPage.TrendingProductName2);
                if (Product != null)
                {
                    TrendingProductList.Add(Product);
                }
                Product = _db.ProductModel.FirstOrDefault(p => p.Title == IndexPage.TrendingProductName3);
                if (Product != null)
                {
                    TrendingProductList.Add(Product);
                }
            }



            return Page();
        }
    }
}
