using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class ListNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "4059b069-509a-4f1b-b7dd-72f356e10b53");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "2f922c23-6966-4b2d-9743-07e1360008b3");

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderPhoto", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "47676cae-9b83-465d-b4f5-6c39fb33245a", "IndexPageModel", 1, "IndexPageModel", "Index", "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", "Default Product 1", "Default Product 2", "Default Product 3", "Default Product 4", "Default Product 5", "Default Product 6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "3ff823cf-5e67-473c-9d83-952612ac0593", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "47676cae-9b83-465d-b4f5-6c39fb33245a");

            migrationBuilder.DeleteData(
                table: "PageModel",
                keyColumn: "Id",
                keyValue: "3ff823cf-5e67-473c-9d83-952612ac0593");

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderPhoto", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "4059b069-509a-4f1b-b7dd-72f356e10b53", "IndexPageModel", 1, "IndexPageModel", "Index", "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", "1", "2", "3", "4", "5", "6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "2f922c23-6966-4b2d-9743-07e1360008b3", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });
        }
    }
}
