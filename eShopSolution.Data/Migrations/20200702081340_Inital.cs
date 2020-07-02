using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppConfigs",
                table: "AppConfigs");

            migrationBuilder.RenameTable(
                name: "AppConfigs",
                newName: "AppConfig");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 2, 15, 13, 40, 157, DateTimeKind.Local).AddTicks(4334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 29, 21, 20, 57, 232, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppConfig",
                table: "AppConfig",
                column: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppConfig",
                table: "AppConfig");

            migrationBuilder.RenameTable(
                name: "AppConfig",
                newName: "AppConfigs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 29, 21, 20, 57, 232, DateTimeKind.Local).AddTicks(9768),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 2, 15, 13, 40, 157, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppConfigs",
                table: "AppConfigs",
                column: "Key");
        }
    }
}
