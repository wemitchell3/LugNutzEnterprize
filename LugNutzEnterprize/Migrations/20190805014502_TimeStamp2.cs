using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class TimeStamp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDated",
                table: "MaintenanceTask");

            migrationBuilder.DropColumn(
                name: "ModeifiedDate",
                table: "MaintenanceTask");

            migrationBuilder.DropColumn(
                name: "UserCreated",
                table: "MaintenanceTask");

            migrationBuilder.DropColumn(
                name: "UserModified",
                table: "MaintenanceTask");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "edfac1ce-3cf1-4212-b649-895846cba16c", "AQAAAAEAACcQAAAAEBbjQ4JLMrFJ0QnNuyEnXtuGlPvicJIWB0SyiZ9S+f3iJNMCewz7GcXW0mIvoZy+HA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "036cf18c-e849-410c-a25c-11da941ec816", "AQAAAAEAACcQAAAAEBgFZQcUpWvskFYeJcrrZZogJxdKfA3bodJudiBySbTGXRAQWe6zn75SFtfMO9TnoQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDated",
                table: "MaintenanceTask",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModeifiedDate",
                table: "MaintenanceTask",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreated",
                table: "MaintenanceTask",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserModified",
                table: "MaintenanceTask",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e39fa48-3f2b-412a-af07-48f87b7c3b54", "AQAAAAEAACcQAAAAECOVIzgqi567oDf3QiSNCyLXvCvSrcGNXBLjbBxGOQ+ceE6meFuhj/THR7dwPqYVrg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a678580-4c9a-4b24-b1d6-d359504a7203", "AQAAAAEAACcQAAAAEBIJw99u9I8ImDTiean8p84fpr8cdFP6U5krCyrZzVbYwTGiAmlDwNjFU2QS7ukEng==" });
        }
    }
}
