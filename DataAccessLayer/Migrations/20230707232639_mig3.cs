using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "CustomerAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 8, 2, 26, 39, 9, DateTimeKind.Local).AddTicks(9609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 8, 2, 24, 38, 778, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.AlterColumn<int>(
                name: "ConfirmCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "AccountProcesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 8, 2, 26, 39, 9, DateTimeKind.Local).AddTicks(9117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 8, 2, 24, 38, 778, DateTimeKind.Local).AddTicks(1080));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "CustomerAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 8, 2, 24, 38, 778, DateTimeKind.Local).AddTicks(1643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 8, 2, 26, 39, 9, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.AlterColumn<int>(
                name: "ConfirmCode",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "AccountProcesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 8, 2, 24, 38, 778, DateTimeKind.Local).AddTicks(1080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 8, 2, 26, 39, 9, DateTimeKind.Local).AddTicks(9117));
        }
    }
}
