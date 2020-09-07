using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class HeaderSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "c6f02432-1794-4d4e-8d4f-05987d7aebf9");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "0f33d86a-5dbe-46bf-9f40-d6220818464c");

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderDescription", "HeaderPhotoPath", "HeaderTitle", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "7aade161-59ac-4fbd-9274-48ba3a25ff64", "IndexPageModel", 1, "IndexPageModel", "Index", "Default Description Placeholder", "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", "Default Title", "Default Product 1", "Default Product 2", "Default Product 3", "Default Product 4", "Default Product 5", "Default Product 6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "bd79b0d2-0e17-4fcd-9097-2cdf1fd55c01", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "7aade161-59ac-4fbd-9274-48ba3a25ff64");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "bd79b0d2-0e17-4fcd-9097-2cdf1fd55c01");

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderDescription", "HeaderPhotoPath", "HeaderTitle", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "c6f02432-1794-4d4e-8d4f-05987d7aebf9", "IndexPageModel", 1, "IndexPageModel", "Index", null, "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", null, "Default Product 1", "Default Product 2", "Default Product 3", "Default Product 4", "Default Product 5", "Default Product 6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "0f33d86a-5dbe-46bf-9f40-d6220818464c", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }
    }
}
