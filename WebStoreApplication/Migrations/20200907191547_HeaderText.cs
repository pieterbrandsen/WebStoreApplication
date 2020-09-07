using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class HeaderText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "a5e01d91-859d-4d83-9816-e59299bf1dd6");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "03ee1e58-055c-4824-8bbd-320a22258944");

            migrationBuilder.AddColumn<string>(
                name: "HeaderDescription",
                table: "PageModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeaderTitle",
                table: "PageModel",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "HeaderDescription",
                table: "PageModel");

            migrationBuilder.DropColumn(
                name: "HeaderTitle",
                table: "PageModel");

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderPhoto", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "a5e01d91-859d-4d83-9816-e59299bf1dd6", "IndexPageModel", 1, "IndexPageModel", "Index", "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", "Default Product 1", "Default Product 2", "Default Product 3", "Default Product 4", "Default Product 5", "Default Product 6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "03ee1e58-055c-4824-8bbd-320a22258944", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }
    }
}
