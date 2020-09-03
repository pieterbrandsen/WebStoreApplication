using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class productInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileModel_AspNetUsers_ModelUserId",
                table: "FileModel");

            migrationBuilder.DropIndex(
                name: "IX_FileModel_ModelUserId",
                table: "FileModel");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FileModel");

            migrationBuilder.DropColumn(
                name: "ModelUserId",
                table: "FileModel");

            migrationBuilder.DropColumn(
                name: "BTW_Number",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyAddres",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KVK_Number",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Chest",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LegLength",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Waist",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "ProductModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    FilePath = table.Column<string>(nullable: true),
                    FilePath2 = table.Column<string>(nullable: true),
                    FilePath3 = table.Column<string>(nullable: true),
                    FilePath4 = table.Column<string>(nullable: true),
                    FilePath5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductModel");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FileModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModelUserId",
                table: "FileModel",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BTW_Number",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyAddres",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KVK_Number",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Chest",
                table: "AspNetUsers",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Height",
                table: "AspNetUsers",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "LegLength",
                table: "AspNetUsers",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Waist",
                table: "AspNetUsers",
                type: "real",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileModel_ModelUserId",
                table: "FileModel",
                column: "ModelUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileModel_AspNetUsers_ModelUserId",
                table: "FileModel",
                column: "ModelUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
