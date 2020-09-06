using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Pages.Admin.Products
{
    [Authorize(Roles = RoleNames.Admin)]
    public class ProductEditModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;

        public ProductEditModel(IWebHostEnvironment environment,
                                UserManager<IdentityUser> userManager,
                                ApplicationDbContext db)
        {
            _environment = environment;
            _userManager = userManager;
            _db = db;
        }


        public string removePhoto;



        [BindProperty]
        public IFormFile Upload { get; set; }
        [BindProperty]
        public IFormFile Upload2 { get; set; }
        [BindProperty]
        public IFormFile Upload3 { get; set; }
        [BindProperty]
        public IFormFile Upload4 { get; set; }
        [BindProperty]
        public IFormFile Upload5 { get; set; }

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
                ProductModel = _db.ProductModel.FirstOrDefault(p => p.Id == Id)
        };
            DescriptionList = Input.ProductModel.Description.Split("<br>");
            AdditionalInformationList = Input.ProductModel.AdditionalInformation.Split("<br>");


            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string Id)
        {
            product = _db.ProductModel.FirstOrDefault(p => p.Id == Id);
            if (product == null)
            {
                return NotFound($"Unable to load product with ID '{Id}'.");
            }


            product.Title = Input.ProductModel.Title;
            product.Description = Input.ProductModel.Description;
            product.AdditionalInformation = Input.ProductModel.AdditionalInformation;
            product.Price = Input.ProductModel.Price;
            product.Visible = Input.ProductModel.Visible;


            product.FilePath = Input.ProductModel.FilePath;


            var directoryPath = Path.Combine(_environment.ContentRootPath, "wwwroot", "Products", product.Title);
            Directory.CreateDirectory(directoryPath);

            if (Upload != null)
            {
                var file = Path.Combine(directoryPath, Path.GetFileName(Upload.FileName));
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    if (Upload.ContentType.ToString().Contains("image"))
                        await Upload.CopyToAsync(fileStream);
                }

                product.FilePath = Path.Combine(@"\Products", product.Title, Path.GetFileName(file));
            }


            if (Upload2 != null)
            {
                var file = Path.Combine(directoryPath, Path.GetFileName(Upload2.FileName));
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    if (Upload2.ContentType.ToString().Contains("image"))
                        await Upload2.CopyToAsync(fileStream);
                }

                product.FilePath2 = Path.Combine(@"\Products", product.Title, Path.GetFileName(file));
            }


            if (Upload3 != null)
            {
                var file = Path.Combine(directoryPath, Path.GetFileName(Upload3.FileName));
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    if (Upload3.ContentType.ToString().Contains("image"))
                        await Upload3.CopyToAsync(fileStream);
                }

                product.FilePath3 = Path.Combine(@"\Products", product.Title, Path.GetFileName(file));
            }


            if (Upload4 != null)
            {
                var file = Path.Combine(directoryPath, Path.GetFileName(Upload4.FileName));
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    if (Upload4.ContentType.ToString().Contains("image"))
                        await Upload4.CopyToAsync(fileStream);
                }

                product.FilePath4 = Path.Combine(@"\Products", product.Title, Path.GetFileName(file));
            }


            if (Upload5 != null)
            {
                var file = Path.Combine(directoryPath, Path.GetFileName(Upload5.FileName));
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    if (Upload5.ContentType.ToString().Contains("image"))
                        await Upload5.CopyToAsync(fileStream);
                }

                product.FilePath5 = Path.Combine(@"\Products", product.Title, Path.GetFileName(file));
            }



            _db.ProductModel.Update(product);
            _db.SaveChanges();
            return RedirectToPage();
        }
    }
}
