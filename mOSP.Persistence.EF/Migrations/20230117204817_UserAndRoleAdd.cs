using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mOSP.Persistence.EF.Migrations
{
    public partial class UserAndRoleAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    OspID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Osps_OspID",
                        column: x => x.OspID,
                        principalTable: "Osps",
                        principalColumn: "OspId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 17, 21, 48, 17, 321, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 17, 21, 48, 17, 321, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 17, 21, 48, 17, 321, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 17, 21, 48, 17, 321, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 17, 21, 48, 17, 321, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 1, 17, 21, 48, 17, 318, DateTimeKind.Local).AddTicks(1108), new DateTime(2023, 3, 8, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 1, 17, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4950), new DateTime(2023, 3, 9, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 1, 17, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4972), new DateTime(2023, 3, 11, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 1, 17, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4979), new DateTime(2023, 3, 12, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 1, 17, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4986), new DateTime(2023, 3, 13, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_OspID",
                table: "Users",
                column: "OspID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 9, 20, 23, 20, 496, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 9, 20, 23, 20, 496, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 9, 20, 23, 20, 496, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 9, 20, 23, 20, 496, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 9, 20, 23, 20, 496, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 9, 20, 23, 20, 474, DateTimeKind.Local).AddTicks(7001), new DateTime(2022, 12, 29, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 9, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7916), new DateTime(2022, 12, 30, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 9, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 1, 1, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 9, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 1, 2, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 9, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 1, 3, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7992) });
        }
    }
}
