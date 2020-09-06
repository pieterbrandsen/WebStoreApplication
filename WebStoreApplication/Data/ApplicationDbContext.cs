using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Models;

namespace WebStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ProductModel> ProductModel { get; internal set; }
        public DbSet<PagesModel> PageModel { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string defaultDescription = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ";
            string defailtAdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
";

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IndexPageModel>().HasData(
                new IndexPageModel { Id = Guid.NewGuid().ToString(), PageName = "Index", LayoutNumber = 1, PageModelName = PageModelNamesClass.IndexPageModel, HeaderPhoto = "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", TopProductName1 = "Default Product 1", TopProductName2 = "Default Product 2", TopProductName3 = "Default Product 3", TrendingProductName1 = "Default Product 4", TrendingProductName2 = "Default Product 5", TrendingProductName3 = "Default Product 6" }) ;
            modelBuilder.Entity<ProductPageModel>().HasData(
                new ProductPageModel { Id = Guid.NewGuid().ToString(), PageName = "ProductPage", LayoutNumber = 1, PageModelName = PageModelNamesClass.ProductPageModel }
            );

            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { Id = 1.ToString(), Title = "Default Product 1", Description = defaultDescription, AdditionalInformation = defailtAdditionalInformation, Price = 9.99, Visible = true, FilePath="https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477" },
                new ProductModel { Id = 2.ToString(), Title = "Default Product 2", Description = defaultDescription, AdditionalInformation = defailtAdditionalInformation, Price = 9.99, Visible = true, FilePath="https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477" },
                new ProductModel { Id = 3.ToString(), Title = "Default Product 3", Description = defaultDescription, AdditionalInformation = defailtAdditionalInformation, Price = 9.99, Visible = true, FilePath="https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477" },
                new ProductModel { Id = 4.ToString(), Title = "Default Product 4", Description = defaultDescription, AdditionalInformation = defailtAdditionalInformation, Price = 9.99, Visible = true, FilePath="https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477" },
                new ProductModel { Id = 5.ToString(), Title = "Default Product 5", Description = defaultDescription, AdditionalInformation = defailtAdditionalInformation, Price = 9.99, Visible = true, FilePath="https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477" },
            
                new ProductModel { Id = 6.ToString(), Title = "Default Product 6", Description = defaultDescription, AdditionalInformation = defailtAdditionalInformation, Price = 9.99, Visible = true, FilePath="https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477" },
                new ProductModel { Id = 7.ToString(), Title = "Default Product 7", Description = defaultDescription, AdditionalInformation = defailtAdditionalInformation, Price = 9.99, Visible = true, FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477" },
                new ProductModel { Id = 8.ToString(), Title = "Default Product 8", Description = defaultDescription, AdditionalInformation = defailtAdditionalInformation, Price = 9.99, Visible = true, FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477" },
                new ProductModel { Id = 9.ToString(), Title = "Default Product 9", Description = defaultDescription, AdditionalInformation = defailtAdditionalInformation, Price = 9.99, Visible = true, FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477" },
                new ProductModel { Id = 10.ToString(), Title = "Default Product 10", Description = defaultDescription, AdditionalInformation = defailtAdditionalInformation, Price = 9.99, Visible = true, FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477" }
            );
        }
    }
}
