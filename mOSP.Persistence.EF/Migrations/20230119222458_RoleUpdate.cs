using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mOSP.Persistence.EF.Migrations
{
    public partial class RoleUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Name" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Manager" },
                    { 3, "Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3);

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
        }
    }
}
