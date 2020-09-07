﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebStore.Data;

namespace WebStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200907191547_HeaderText")]
    partial class HeaderText
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebStore.Models.PagesModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LayoutNumber")
                        .HasColumnType("int");

                    b.Property<string>("PageModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PageModel");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PagesModel");
                });

            modelBuilder.Entity("WebStore.Models.ProductModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ProductModel");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
",
                            Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ",
                            FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477",
                            Price = 9.9900000000000002,
                            Title = "Default Product 1",
                            Visible = true
                        },
                        new
                        {
                            Id = "2",
                            AdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
",
                            Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ",
                            FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477",
                            Price = 9.9900000000000002,
                            Title = "Default Product 2",
                            Visible = true
                        },
                        new
                        {
                            Id = "3",
                            AdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
",
                            Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ",
                            FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477",
                            Price = 9.9900000000000002,
                            Title = "Default Product 3",
                            Visible = true
                        },
                        new
                        {
                            Id = "4",
                            AdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
",
                            Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ",
                            FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477",
                            Price = 9.9900000000000002,
                            Title = "Default Product 4",
                            Visible = true
                        },
                        new
                        {
                            Id = "5",
                            AdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
",
                            Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ",
                            FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477",
                            Price = 9.9900000000000002,
                            Title = "Default Product 5",
                            Visible = true
                        },
                        new
                        {
                            Id = "6",
                            AdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
",
                            Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ",
                            FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477",
                            Price = 9.9900000000000002,
                            Title = "Default Product 6",
                            Visible = true
                        },
                        new
                        {
                            Id = "7",
                            AdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
",
                            Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ",
                            FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477",
                            Price = 9.9900000000000002,
                            Title = "Default Product 7",
                            Visible = true
                        },
                        new
                        {
                            Id = "8",
                            AdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
",
                            Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ",
                            FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477",
                            Price = 9.9900000000000002,
                            Title = "Default Product 8",
                            Visible = true
                        },
                        new
                        {
                            Id = "9",
                            AdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
",
                            Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ",
                            FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477",
                            Price = 9.9900000000000002,
                            Title = "Default Product 9",
                            Visible = true
                        },
                        new
                        {
                            Id = "10",
                            AdditionalInformation = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed congue eros id vestibulum ultricies. Nulla id dui id sapien auctor euismod in sit amet sem. Nunc congue eget lacus et ultricies. Nulla vel ipsum pharetra turpis rutrum dapibus. Integer varius ac massa vitae mollis. Quisque finibus auctor neque eget ultrices. Nullam auctor felis in accumsan sollicitudin. Duis rhoncus urna nec mi egestas dignissim sit amet eget odio.
",
                            Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat fermentum ipsum, eu semper elit hendrerit nec. Suspendisse malesuada ipsum eu tempus sagittis. Aenean a magna eget est sodales imperdiet. Nulla facilisi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque accumsan dolor ac mi euismod, id consequat est sodales. Ut vitae rutrum augue, et gravida lorem.<br><br>
Quisque ut luctus odio. Fusce a massa semper, ullamcorper justo ac, porttitor velit. Duis vestibulum ipsum id diam lacinia elementum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus ex ante, lacinia tincidunt tortor nec, viverra fermentum ligula. In hac habitasse platea dictumst. In dictum luctus egestas. Integer euismod iaculis ante id porttitor. Duis tincidunt ac purus vel ornare. Sed at auctor orci. Quisque venenatis lacus ligula, quis dignissim purus vulputate in. Suspendisse posuere arcu non orci cursus varius. Nulla consectetur sapien sit amet vehicula convallis. Duis ante lacus, dignissim ac bibendum non, commodo ac sapien. Pellentesque vestibulum vulputate tempor.
                    ",
                            FilePath = "https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-product-6_large.png?format=jpg&quality=90&v=1530129477",
                            Price = 9.9900000000000002,
                            Title = "Default Product 10",
                            Visible = true
                        });
                });

            modelBuilder.Entity("WebStore.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("WebStore.Models.IndexPageModel", b =>
                {
                    b.HasBaseType("WebStore.Models.PagesModel");

                    b.Property<string>("HeaderDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopProductName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopProductName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopProductName3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrendingProductName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrendingProductName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrendingProductName3")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("IndexPageModel");

                    b.HasData(
                        new
                        {
                            Id = "847ef4a8-3897-49d1-b35f-e9af528c7fa0",
                            LayoutNumber = 1,
                            PageModelName = "IndexPageModel",
                            PageName = "Index",
                            HeaderPhoto = "https://insidesmallbusiness.com.au/wp-content/uploads/2018/04/brad-header-placeholder.png",
                            TopProductName1 = "Default Product 1",
                            TopProductName2 = "Default Product 2",
                            TopProductName3 = "Default Product 3",
                            TrendingProductName1 = "Default Product 4",
                            TrendingProductName2 = "Default Product 5",
                            TrendingProductName3 = "Default Product 6"
                        });
                });

            modelBuilder.Entity("WebStore.Models.ProductPageModel", b =>
                {
                    b.HasBaseType("WebStore.Models.PagesModel");

                    b.HasDiscriminator().HasValue("ProductPageModel");

                    b.HasData(
                        new
                        {
                            Id = "3519c081-db3e-4c22-9824-2f748f9afc02",
                            LayoutNumber = 1,
                            PageModelName = "ProductPageModel",
                            PageName = "ProductPage"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
