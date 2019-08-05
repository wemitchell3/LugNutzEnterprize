using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class WishList1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "WishList");

            migrationBuilder.AddColumn<byte[]>(
                name: "CreatedDate",
                table: "WishList",
                rowVersion: true,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2101b75c-6e98-4425-b938-f415d39c0b59", "AQAAAAEAACcQAAAAEJNNAH35zQPp+nyQMQzl+fvNBqPqUEYRdcqTehr5BOiUq4od4X+f+EziAWIDBNYdCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e68b9ae-9c63-4ada-8712-50713e5cf4a5", "AQAAAAEAACcQAAAAEJK1Ook6owsYlLY7/Z3Vq3G7uvpD4swZsFAyGjyDHbe4+JVQbt1PMRoIIs36rDKEAA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "WishList");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "WishList",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
