using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class HeaderTextColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "7aade161-59ac-4fbd-9274-48ba3a25ff64");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "bd79b0d2-0e17-4fcd-9097-2cdf1fd55c01");

            migrationBuilder.AddColumn<string>(
                name: "HeaderTextColor",
                table: "PageModel",
                nullable: true);

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderDescription", "HeaderPhotoPath", "HeaderTextColor", "HeaderTitle", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "e4bdc416-4b6b-4178-94df-068c2a0fb7a9", "IndexPageModel", 1, "IndexPageModel", "Index", "Default Description Placeholder", "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", "#000000", "Default Title", "Default Product 1", "Default Product 2", "Default Product 3", "Default Product 4", "Default Product 5", "Default Product 6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "02b6e2e6-e5a4-47c8-865f-249c4fd31c45", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "e4bdc416-4b6b-4178-94df-068c2a0fb7a9");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "02b6e2e6-e5a4-47c8-865f-249c4fd31c45");

            migrationBuilder.DropColumn(
                name: "HeaderTextColor",
                table: "PageModel");

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderDescription", "HeaderPhotoPath", "HeaderTitle", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "7aade161-59ac-4fbd-9274-48ba3a25ff64", "IndexPageModel", 1, "IndexPageModel", "Index", "Default Description Placeholder", "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", "Default Title", "Default Product 1", "Default Product 2", "Default Product 3", "Default Product 4", "Default Product 5", "Default Product 6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "bd79b0d2-0e17-4fcd-9097-2cdf1fd55c01", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }
    }
}
