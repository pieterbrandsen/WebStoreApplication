using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class HeaderDividerColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "e4bdc416-4b6b-4178-94df-068c2a0fb7a9");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "02b6e2e6-e5a4-47c8-865f-249c4fd31c45");

            migrationBuilder.AddColumn<string>(
                name: "HeaderDividerColor",
                table: "PageModel",
                nullable: true);

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderDescription", "HeaderDividerColor", "HeaderPhotoPath", "HeaderTextColor", "HeaderTitle", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "7efe34eb-0e08-4aa4-bfd2-72b7b8edc56c", "IndexPageModel", 1, "IndexPageModel", "Index", "Default Description Placeholder", "#000000", "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", "#000000", "Default Title", "Default Product 1", "Default Product 2", "Default Product 3", "Default Product 4", "Default Product 5", "Default Product 6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "d87d1773-2227-40a7-b2b7-f36601d79607", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "7efe34eb-0e08-4aa4-bfd2-72b7b8edc56c");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "d87d1773-2227-40a7-b2b7-f36601d79607");

            migrationBuilder.DropColumn(
                name: "HeaderDividerColor",
                table: "PageModel");

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderDescription", "HeaderPhotoPath", "HeaderTextColor", "HeaderTitle", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "e4bdc416-4b6b-4178-94df-068c2a0fb7a9", "IndexPageModel", 1, "IndexPageModel", "Index", "Default Description Placeholder", "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", "#000000", "Default Title", "Default Product 1", "Default Product 2", "Default Product 3", "Default Product 4", "Default Product 5", "Default Product 6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "02b6e2e6-e5a4-47c8-865f-249c4fd31c45", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }
    }
}
