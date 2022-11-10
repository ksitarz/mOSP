using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mOSP.Persistence.EF.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Osps",
                columns: table => new
                {
                    OspId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osps", x => x.OspId);
                });

            migrationBuilder.CreateTable(
                name: "Container",
                columns: table => new
                {
                    ContainerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OspId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContainerType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Container", x => x.ContainerId);
                    table.ForeignKey(
                        name: "FK_Container_Osps_OspId",
                        column: x => x.OspId,
                        principalTable: "Osps",
                        principalColumn: "OspId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContainerId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsIgnored = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_Container_ContainerId",
                        column: x => x.ContainerId,
                        principalTable: "Container",
                        principalColumn: "ContainerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Osps",
                columns: new[] { "OspId", "Name" },
                values: new object[] { 1, "OSP1" });

            migrationBuilder.InsertData(
                table: "Osps",
                columns: new[] { "OspId", "Name" },
                values: new object[] { 2, "OSP2" });

            migrationBuilder.InsertData(
                table: "Container",
                columns: new[] { "ContainerId", "ContainerType", "CreatedDate", "Discriminator", "Name", "OspId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2022, 11, 9, 20, 23, 20, 496, DateTimeKind.Local).AddTicks(7630), "MedKit", "Kit1", 1 },
                    { 2, 0, new DateTime(2022, 11, 9, 20, 23, 20, 496, DateTimeKind.Local).AddTicks(8365), "MedKit", "Kit2", 1 },
                    { 3, 0, new DateTime(2022, 11, 9, 20, 23, 20, 496, DateTimeKind.Local).AddTicks(8393), "MedKit", "Kit3", 1 },
                    { 4, 0, new DateTime(2022, 11, 9, 20, 23, 20, 496, DateTimeKind.Local).AddTicks(8400), "MedKit", "Kit4", 1 },
                    { 5, 0, new DateTime(2022, 11, 9, 20, 23, 20, 496, DateTimeKind.Local).AddTicks(8406), "MedKit", "Kit5", 1 }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "ContainerId", "CreatedDate", "Discriminator", "ExpirationDate", "IsIgnored", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 11, 9, 20, 23, 20, 474, DateTimeKind.Local).AddTicks(7001), "MedItem", new DateTime(2022, 12, 29, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(6402), false, "Item1" },
                    { 2, 1, new DateTime(2022, 11, 9, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7916), "MedItem", new DateTime(2022, 12, 30, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7948), false, "Item2" },
                    { 3, 1, new DateTime(2022, 11, 9, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7958), "MedItem", new DateTime(2023, 1, 1, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7964), false, "Item3" },
                    { 4, 1, new DateTime(2022, 11, 9, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7973), "MedItem", new DateTime(2023, 1, 2, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7979), false, "Item4" },
                    { 5, 1, new DateTime(2022, 11, 9, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7986), "MedItem", new DateTime(2023, 1, 3, 20, 23, 20, 493, DateTimeKind.Local).AddTicks(7992), false, "Item5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Container_OspId",
                table: "Container",
                column: "OspId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ContainerId",
                table: "Item",
                column: "ContainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Container");

            migrationBuilder.DropTable(
                name: "Osps");
        }
    }
}
