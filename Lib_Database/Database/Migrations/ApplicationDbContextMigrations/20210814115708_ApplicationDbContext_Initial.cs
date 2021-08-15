using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lib_Database.Database.Migrations.ApplicationDbContextMigrations
{
    public partial class ApplicationDbContext_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SmtpServer = table.Column<string>(type: "TEXT", nullable: true),
                    MailServerUserName = table.Column<string>(type: "TEXT", nullable: true),
                    MailServerUserPassword = table.Column<string>(type: "TEXT", nullable: true),
                    ToEmailAddress = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Occupation = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactEntityCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEntityCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ToEmailAddress = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "ContactEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContactName = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    IsChecked = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    ContactEntityCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactEntities_ContactEntityCategories_ContactEntityCategoryId",
                        column: x => x.ContactEntityCategoryId,
                        principalTable: "ContactEntityCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppModels",
                columns: new[] { "Id", "MailServerUserName", "MailServerUserPassword", "SmtpServer", "ToEmailAddress" },
                values: new object[] { 1, "===============", "===============", "===============", "===============" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "e7dd2d83-3c07-4cb4-ad81-f738c4440677", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "3029ac2c-9f9d-4987-b5bf-73a9f245ae2a", "SuperAdmin", "SUPERADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3", "ba96b1f6-3d08-41ec-b63b-9eb01852bbe2", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4", "b30a4757-7d65-402f-b5be-5e2bcbeb741d", "RegularUser", "REGULARUSER" });

            migrationBuilder.InsertData(
                table: "ContactEntityCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Unspecified" });

            migrationBuilder.InsertData(
                table: "ContactEntityCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Owner" });

            migrationBuilder.InsertData(
                table: "ContactEntityCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Family" });

            migrationBuilder.InsertData(
                table: "ContactEntityCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Friend" });

            migrationBuilder.InsertData(
                table: "ContactEntityCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Home" });

            migrationBuilder.InsertData(
                table: "ContactEntityCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Work" });

            migrationBuilder.InsertData(
                table: "ContactEntityCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Business" });

            migrationBuilder.InsertData(
                table: "DevUser",
                columns: new[] { "Id", "ToEmailAddress" },
                values: new object[] { 1, "curious-coder@outlook.com" });

            migrationBuilder.InsertData(
                table: "ContactEntities",
                columns: new[] { "Id", "Address", "ContactEntityCategoryId", "ContactName", "CreatedDate", "Email", "FirstName", "Image", "IsChecked", "LastName", "Phone" },
                values: new object[] { 1, "5 Grand Lodge, London UK", 3, "Jane Doe", new DateTimeOffset(new DateTime(2021, 8, 14, 11, 57, 8, 395, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 0, 0, 0, 0)), "jane@doe.com", "Jane", "https://localhost:5551/Images/UploadFiles/Default.png", false, "Doe", "01111111111" });

            migrationBuilder.InsertData(
                table: "ContactEntities",
                columns: new[] { "Id", "Address", "ContactEntityCategoryId", "ContactName", "CreatedDate", "Email", "FirstName", "Image", "IsChecked", "LastName", "Phone" },
                values: new object[] { 2, "14 The Glades, New York US", 4, "Tom Browne", new DateTimeOffset(new DateTime(2021, 8, 14, 11, 57, 8, 396, DateTimeKind.Unspecified).AddTicks(1744), new TimeSpan(0, 0, 0, 0, 0)), "tom@browne.com", "Tom", "https://localhost:5551/Images/UploadFiles/Default.png", false, "Browne", "02111111111" });

            migrationBuilder.InsertData(
                table: "ContactEntities",
                columns: new[] { "Id", "Address", "ContactEntityCategoryId", "ContactName", "CreatedDate", "Email", "FirstName", "Image", "IsChecked", "LastName", "Phone" },
                values: new object[] { 3, "5 Hoble House, Penge, London UK", 6, "Lucy Smith", new DateTimeOffset(new DateTime(2021, 8, 14, 11, 57, 8, 396, DateTimeKind.Unspecified).AddTicks(1751), new TimeSpan(0, 0, 0, 0, 0)), "lucy@smith.com", "Lucy", "https://localhost:5551/Images/UploadFiles/Default.png", false, "Smith", "03111111111" });

            migrationBuilder.InsertData(
                table: "ContactEntities",
                columns: new[] { "Id", "Address", "ContactEntityCategoryId", "ContactName", "CreatedDate", "Email", "FirstName", "Image", "IsChecked", "LastName", "Phone" },
                values: new object[] { 4, "11 Broad Lane, Paris France", 7, "Halie Jones", new DateTimeOffset(new DateTime(2021, 8, 14, 11, 57, 8, 396, DateTimeKind.Unspecified).AddTicks(1753), new TimeSpan(0, 0, 0, 0, 0)), "halie@jones.com", "Halie", "https://localhost:5551/Images/UploadFiles/Default.png", false, "Jones", "04111111111" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactEntities_ContactEntityCategoryId",
                table: "ContactEntities",
                column: "ContactEntityCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppModels");

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
                name: "ContactEntities");

            migrationBuilder.DropTable(
                name: "DevUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ContactEntityCategories");
        }
    }
}
