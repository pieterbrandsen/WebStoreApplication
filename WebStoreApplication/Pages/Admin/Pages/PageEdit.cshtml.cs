using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Pages.Admin.Pages
{
    [Authorize(Roles = RoleNames.Admin)]
    public class PageEditModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;

        public PageEditModel(IWebHostEnvironment environment,
                                UserManager<IdentityUser> userManager,
                                ApplicationDbContext db)
        {
            _environment = environment;
            _userManager = userManager;
            _db = db;
        }


        public IndexPageModel IndexPageModel { get; set; }
        public ProductPageModel ProductPageModel { get; set; }

        public List<string> TopProductList { get; set; } 

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            public PagesModel PageModel { get; set; }
            public IndexPageModel IndexPageModel { get; set; }
            public ProductPageModel ProductPageModel { get; set; }
        }

        public IActionResult OnGet(string Id)
        {
            var page = _db.PageModel.FirstOrDefault(p => p.Id == Id);

            if (page.PageModelName == PageModelNamesClass.IndexPageModel)
            {
                Input = new InputModel
                {
                    PageModel = page,
                    IndexPageModel = (IndexPageModel)_db.PageModel.FirstOrDefault(p => p.Id == Id),
                };
            }
            else if (page.PageModelName == PageModelNamesClass.ProductPageModel)
            {
                Input = new InputModel
                {
                    PageModel = page,
                    ProductPageModel = (ProductPageModel)_db.PageModel.FirstOrDefault(p => p.Id == Id)
                };
            }


            return Page();
        }

        public IActionResult OnPost(string Id)
        {
            var page = _db.PageModel.FirstOrDefault(p => p.Id == Id);

            if (page.PageModelName == PageModelNamesClass.IndexPageModel)
            {
                IndexPageModel = (IndexPageModel)_db.PageModel.FirstOrDefault(p => p.Id == Id);
                IndexPageModel.LayoutNumber = Input.PageModel.LayoutNumber;
                IndexPageModel.TopProductName1 = Input.IndexPageModel.TopProductName1;
                IndexPageModel.TopProductName2 = Input.IndexPageModel.TopProductName2;
                IndexPageModel.TopProductName3 = Input.IndexPageModel.TopProductName3;
                IndexPageModel.TrendingProductName1 = Input.IndexPageModel.TrendingProductName1;
                IndexPageModel.TrendingProductName2 = Input.IndexPageModel.TrendingProductName2;
                IndexPageModel.TrendingProductName3 = Input.IndexPageModel.TrendingProductName3;


                _db.PageModel.Update(IndexPageModel);
            var page2 = _db.PageModel.FirstOrDefault(p => p.Id == Id);
                _db.SaveChanges();
            var page3 = _db.PageModel.FirstOrDefault(p => p.Id == Id);

            }
            else if (page.PageModelName == PageModelNamesClass.ProductPageModel)
            {
                ProductPageModel = (ProductPageModel)_db.PageModel.FirstOrDefault(p => p.Id == Id);
                ProductPageModel.LayoutNumber = Input.PageModel.LayoutNumber;

                _db.PageModel.Update(ProductPageModel);
                _db.SaveChanges();
            }


            return RedirectToPage();
        }
    }
}
