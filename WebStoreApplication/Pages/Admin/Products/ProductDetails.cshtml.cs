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
        public string[] DescriptionList;
        public string[] AdditionalInformationList;

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
                ProductModel = _db.ProductModel.FirstOrDefault(p => p.Id == Id),
            };

            if (Input.ProductModel.Description != null)
            {
                DescriptionList = Input.ProductModel.Description.Split("<br>");
            }
            else
            {
                DescriptionList[0] = Input.ProductModel.Description;
            }

            if (Input.ProductModel.AdditionalInformation != null)
            {
                AdditionalInformationList = Input.ProductModel.AdditionalInformation.Split("<br>");
            }
            else
            {
                AdditionalInformationList[0] = Input.ProductModel.AdditionalInformation;
            }


            return Page();
        }
    }
}
