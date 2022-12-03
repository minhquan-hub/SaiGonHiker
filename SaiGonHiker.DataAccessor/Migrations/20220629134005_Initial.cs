using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaiGonHiker.DataAccessor.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    DateOfDeparture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDisabled = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "5ce1261b-ecce-4d12-9c96-2c63ea10678f", "Admin", "ADMIN" },
                    { 2, "7c997e31-1e94-4026-8b34-f0f912e2136c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Tour",
                columns: new[] { "Id", "Address", "DateOfArrival", "DateOfDeparture", "Description", "Image", "IsDelete", "Name", "Price", "Region" },
                values: new object[,]
                {
                    { 11, "Tour11", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour11", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A11", 4500000, "Central" },
                    { 10, "Tour10", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour10", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A10", 1500000, "Southern" },
                    { 9, "Tour9", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour9", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A9", 3500000, "Central" },
                    { 7, "Tour7", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour7", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A7", 500000, "Central" },
                    { 6, "Tour6", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour6", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A6", 500000, "Southern" },
                    { 8, "Tour8", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour8", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A8", 2500000, "Southern" },
                    { 4, "Tour4", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour4", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A4", 500000, "Northern" },
                    { 3, "Tour3", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour3", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A3", 1000000, "Southern" },
                    { 2, "Tour2", new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour2", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A2", 1500000, "Central" },
                    { 1, "Tour1", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour1", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A1", 500000, "Northern" },
                    { 5, "Tour5", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description Tour5", "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg", false, "A5", 500000, "Northern" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "IsDisabled", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserCode", "UserName" },
                values: new object[,]
                {
                    { 5, 0, "District 11, HCM City", "1825478f-95fc-4a89-a021-0e28e0d25a23", "nhit3450@gmail.com", false, "Nhi Tran", "Female", false, false, null, null, null, "AQAAAAEAACcQAAAAECYyvIW1+gaRE6nCxKb4PbUbvGoZwLo/IFnrvcgZv1H59rJJQxu3fNEQVwPCVUTcdA==", "0924721184", false, null, false, "U0005", "nhit345" },
                    { 1, 0, "Binh Chanh District, HCM City", "c3ed25ad-7780-43c1-b22f-6828d9d2f8e2", "minhquan2122000@gmail.com", false, "Quan Tran", "Male", false, false, null, null, null, "AQAAAAEAACcQAAAAEA8uCDwYpsdUMax5mA0DvzV7C2hDtw7JQBRrgCiL6FN2PaWtHFOr/QTS4Ll9J9UTgw==", "0924721184", false, null, false, "U0001", "quant" },
                    { 2, 0, "District 9, HCM City", "cc52f7ce-c258-4bed-8185-c4278be243fb", "khanh2122000@gmail.com", false, "Khanh Tran", "Female", false, false, null, null, null, "AQAAAAEAACcQAAAAENJZywzs76sbRtvYf0vfzhl7XDSRQCJW9B6l7sSMECIuBOikDJGY8v9Lt2jfXtulAg==", "0924721184", false, null, false, "U0002", "khanht" },
                    { 3, 0, "District 5, HCM City", "1ccc9619-668d-485c-a377-69ac41b5f6f9", "hoang123456@gmail.com", false, "Hoang Nguyen", "Male", false, false, null, null, null, "AQAAAAEAACcQAAAAEAS8j2Aiolsl+R0ZZnUPlsiBADH9GtBAkvNbWME9nJ+86ydilfwi7YTkEEXzWA33PQ==", "0924721184", false, null, false, "U0003", "hoangnguyen" },
                    { 4, 0, "District 7, HCM City", "f89b0c88-e396-4cd2-b48e-e2cc8d530c9a", "duocn342@gmail.com", false, "Được Nguyễn", "Male", false, false, null, null, null, "AQAAAAEAACcQAAAAEHbE4Sbe2VUJnRZNqFBsF/cRQSClIO5FE4ma4CcrQvwuxab50FFMp+0boMMxPMYZ3w==", "0924721184", false, null, false, "U0004", "duocn" },
                    { 6, 0, "District 1, HCM City", "aea39c95-1b08-4033-b6c7-96fee255824a", "phuognt234@gmail.com", false, "Phương Trần", "Female", false, false, null, null, null, "AQAAAAEAACcQAAAAEACwoDwwgpQl/WXpIlox0dsB2CX/SwAIkP+t3hZof8zTgleYy9LIYo1ZKDjFjZp2dQ==", "0924721184", false, null, false, "U0006", "phuongt234" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
