using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class HeaderPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "847ef4a8-3897-49d1-b35f-e9af528c7fa0");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "3519c081-db3e-4c22-9824-2f748f9afc02");

            migrationBuilder.DropColumn(
                name: "HeaderPhoto",
                table: "PageModel");

            migrationBuilder.AddColumn<string>(
                name: "HeaderPhotoPath",
                table: "PageModel",
                nullable: true);

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderDescription", "HeaderPhotoPath", "HeaderTitle", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "c6f02432-1794-4d4e-8d4f-05987d7aebf9", "IndexPageModel", 1, "IndexPageModel", "Index", null, "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", null, "Default Product 1", "Default Product 2", "Default Product 3", "Default Product 4", "Default Product 5", "Default Product 6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "0f33d86a-5dbe-46bf-9f40-d6220818464c", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "c6f02432-1794-4d4e-8d4f-05987d7aebf9");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "0f33d86a-5dbe-46bf-9f40-d6220818464c");

            migrationBuilder.DropColumn(
                name: "HeaderPhotoPath",
                table: "PageModel");

            migrationBuilder.AddColumn<string>(
                name: "HeaderPhoto",
                table: "PageModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderDescription", "HeaderPhoto", "HeaderTitle", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "847ef4a8-3897-49d1-b35f-e9af528c7fa0", "IndexPageModel", 1, "IndexPageModel", "Index", null, "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", null, "Default Product 1", "Default Product 2", "Default Product 3", "Default Product 4", "Default Product 5", "Default Product 6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "3519c081-db3e-4c22-9824-2f748f9afc02", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }
    }
}
