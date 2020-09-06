using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    IsVerified = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PageModelName = table.Column<string>(nullable: true),
                    PageName = table.Column<string>(nullable: true),
                    LayoutNumber = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    TopProductName1 = table.Column<string>(nullable: true),
                    TopProductName2 = table.Column<string>(nullable: true),
                    TopProductName3 = table.Column<string>(nullable: true),
                    TrendingProductName1 = table.Column<string>(nullable: true),
                    TrendingProductName2 = table.Column<string>(nullable: true),
                    TrendingProductName3 = table.Column<string>(nullable: true),
                    HeaderPhoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AdditionalInformation = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Visible = table.Column<bool>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName", "HeaderPhoto", "TopProductName1", "TopProductName2", "TopProductName3", "TrendingProductName1", "TrendingProductName2", "TrendingProductName3" },
                values: new object[] { "4059b069-509a-4f1b-b7dd-72f356e10b53", "IndexPageModel", 1, "IndexPageModel", "Index", "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png", "1", "2", "3", "4", "5", "6" });

            migrationBuilder.InsertData(
                table: "PageModel",
                columns: new[] { "Id", "Discriminator", "LayoutNumber", "PageModelName", "PageName" },
                values: new object[] { "2f922c23-6966-4b2d-9743-07e1360008b3", "ProductPageModel", 1, "ProductPageModel", "ProductPage" });

            migrationBuilder.InsertData(
                table: "ProductModel",
                columns: new[] { "Id", "AdditionalInformation", "Description", "FilePath", "FilePath2", "FilePath3", "FilePath4", "FilePath5", "Price", "Title", "Visible" },
                values: new object[,]
                {
                    { "1", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
                ", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
                Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                                    ", "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477", null, null, null, null, 9.9900000000000002, "Default Product 1", true },
                    { "2", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
                ", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
                Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                                    ", "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477", null, null, null, null, 9.9900000000000002, "Default Product 2", true },
                    { "3", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
                ", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
                Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                                    ", "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477", null, null, null, null, 9.9900000000000002, "Default Product 3", true },
                    { "4", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
                ", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
                Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                                    ", "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477", null, null, null, null, 9.9900000000000002, "Default Product 4", true },
                    { "5", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
                ", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
                Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                                    ", "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477", null, null, null, null, 9.9900000000000002, "Default Product 5", true },
                    { "6", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
                ", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
                Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                                    ", "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477", null, null, null, null, 9.9900000000000002, "Default Product 6", true },
                    { "7", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
                ", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
                Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                                    ", "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477", null, null, null, null, 9.9900000000000002, "Default Product 7", true },
                    { "8", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
                ", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
                Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                                    ", "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477", null, null, null, null, 9.9900000000000002, "Default Product 8", true },
                    { "9", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
                ", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
                Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                                    ", "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477", null, null, null, null, 9.9900000000000002, "Default Product 9", true },
                    { "10", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
                ", @"
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
                Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                                    ", "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477", null, null, null, null, 9.9900000000000002, "Default Product 10", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PageModel");

            migrationBuilder.DropTable(
                name: "ProductModel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
