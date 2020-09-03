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
using Microsoft.EntityFrameworkCore;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Pages.Admin.Products
{
    [Authorize(Roles = RoleNames.Admin)]
    public class UploadNewProductModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;

        public UploadNewProductModel(IWebHostEnvironment environment,
                                UserManager<IdentityUser> userManager,
                                ApplicationDbContext db)
        {
            _environment = environment;
            _userManager = userManager;
            _db = db;
        }

        public bool createdProduct = false;

        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string Description { get; set; }
        [BindProperty]
        public double Price { get; set; }
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
        public async Task<IActionResult> OnPostAsync()
        {
            if (_db.ProductModel.Where(f => f.Title == Title).ToArray().Length == 0)
            {

                List<string> productList = new List<string>();


                var directoryPath = Path.Combine(_environment.ContentRootPath, "wwwroot", "Products", Title);
                Directory.CreateDirectory(directoryPath);

                if (Upload != null)
                {
                    var file = Path.Combine(directoryPath, Path.GetFileName(Upload.FileName));
                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        if (Upload.ContentType.ToString().Contains("image"))
                            await Upload.CopyToAsync(fileStream);
                    }

                    productList.Add(Path.Combine("Products", Title, Path.GetFileName(file)));
                }


                if (Upload2 != null)
                {
                    var file = Path.Combine(directoryPath, Path.GetFileName(Upload2.FileName));
                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        if (Upload2.ContentType.ToString().Contains("image"))
                            await Upload2.CopyToAsync(fileStream);
                    }

                    productList.Add(Path.Combine("Products", Title, Path.GetFileName(file)));
                }


                if (Upload3 != null)
                {
                    var file = Path.Combine(directoryPath, Path.GetFileName(Upload3.FileName));
                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        if (Upload3.ContentType.ToString().Contains("image"))
                            await Upload3.CopyToAsync(fileStream);
                    }

                    productList.Add(Path.Combine("Products", Title, Path.GetFileName(file)));
                }


                if (Upload4 != null)
                {
                    var file = Path.Combine(directoryPath, Path.GetFileName(Upload4.FileName));
                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        if (Upload4.ContentType.ToString().Contains("image"))
                            await Upload4.CopyToAsync(fileStream);
                    }

                    productList.Add(Path.Combine("Products", Title, Path.GetFileName(file)));
                }


                if (Upload5 != null)
                {
                    var file = Path.Combine(directoryPath, Path.GetFileName(Upload5.FileName));
                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        if (Upload5.ContentType.ToString().Contains("image"))
                            await Upload5.CopyToAsync(fileStream);
                    }

                    productList.Add(Path.Combine("Products", Title, Path.GetFileName(file)));
                }

                for (int i = 0; i < 5; i++)
                {
                    if (productList.Count() == i)
                    {
                        productList.Add(null);
                    }
                }

                var newProduct = new ProductModel { Id = Guid.NewGuid().ToString(), Title = Title, Description = Description, Price = Price, FilePath = productList[0], FilePath2 = productList[1], FilePath3 = productList[2], FilePath4 = productList[3], FilePath5 = productList[4] };

                _db.ProductModel.Add(newProduct);
                _db.SaveChanges();
                createdProduct = true;
            }
            return Page();
        }
    }
}
