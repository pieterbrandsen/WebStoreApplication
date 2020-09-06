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

namespace WebStore.Pages.Admin.Pages
{
    [Authorize(Roles = RoleNames.Admin)]
    public class PageDetailsModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;

        public PageDetailsModel(IWebHostEnvironment environment,
                                UserManager<IdentityUser> userManager,
                                ApplicationDbContext db)
        {
            _environment = environment;
            _userManager = userManager;
            _db = db;
        }

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
    }
}
