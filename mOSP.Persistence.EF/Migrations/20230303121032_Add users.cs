using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mOSP.Persistence.EF.Migrations
{
    public partial class Addusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Osps_OspID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "OspID",
                table: "Users",
                newName: "OspId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_OspID",
                table: "Users",
                newName: "IX_Users_OspId");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "Roles",
                newName: "RoleId");

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 3, 13, 10, 32, 349, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 3, 13, 10, 32, 349, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 3, 13, 10, 32, 349, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 3, 13, 10, 32, 349, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 3, 13, 10, 32, 349, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 3, 3, 13, 10, 32, 346, DateTimeKind.Local).AddTicks(4172), new DateTime(2023, 4, 22, 13, 10, 32, 348, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 3, 3, 13, 10, 32, 348, DateTimeKind.Local).AddTicks(6166), new DateTime(2023, 4, 23, 13, 10, 32, 348, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 3, 3, 13, 10, 32, 348, DateTimeKind.Local).AddTicks(6182), new DateTime(2023, 4, 25, 13, 10, 32, 348, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 3, 3, 13, 10, 32, 348, DateTimeKind.Local).AddTicks(6187), new DateTime(2023, 4, 26, 13, 10, 32, 348, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 3, 3, 13, 10, 32, 348, DateTimeKind.Local).AddTicks(6191), new DateTime(2023, 4, 27, 13, 10, 32, 348, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Osps_OspId",
                table: "Users",
                column: "OspId",
                principalTable: "Osps",
                principalColumn: "OspId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Osps_OspId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "RoleID");

            migrationBuilder.RenameColumn(
                name: "OspId",
                table: "Users",
                newName: "OspID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                newName: "IX_Users_RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_OspId",
                table: "Users",
                newName: "IX_Users_OspID");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Roles",
                newName: "RoleID");

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 23, 24, 58, 20, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 23, 24, 58, 20, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 23, 24, 58, 20, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 23, 24, 58, 20, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Container",
                keyColumn: "ContainerId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 23, 24, 58, 20, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 1, 19, 23, 24, 58, 17, DateTimeKind.Local).AddTicks(4398), new DateTime(2023, 3, 10, 23, 24, 58, 19, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 1, 19, 23, 24, 58, 19, DateTimeKind.Local).AddTicks(6170), new DateTime(2023, 3, 11, 23, 24, 58, 19, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 1, 19, 23, 24, 58, 19, DateTimeKind.Local).AddTicks(6186), new DateTime(2023, 3, 13, 23, 24, 58, 19, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 1, 19, 23, 24, 58, 19, DateTimeKind.Local).AddTicks(6192), new DateTime(2023, 3, 14, 23, 24, 58, 19, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ExpirationDate" },
                values: new object[] { new DateTime(2023, 1, 19, 23, 24, 58, 19, DateTimeKind.Local).AddTicks(6197), new DateTime(2023, 3, 15, 23, 24, 58, 19, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Osps_OspID",
                table: "Users",
                column: "OspID",
                principalTable: "Osps",
                principalColumn: "OspId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleID",
                table: "Users",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
