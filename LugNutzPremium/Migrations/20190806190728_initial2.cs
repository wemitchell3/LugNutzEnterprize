using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzPremium.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WishList",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Vehicle",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Topic",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Message",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b709cde-b356-43d6-9e46-87858635221b", "AQAAAAEAACcQAAAAEECjUFd7m0mBaZWC4pPPR74L+YEOCaBexZDcD6jikXV/4BHT+s5U94jHJdlqIBbzsw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18437cb4-c565-4872-8b2d-a13914817d1f", "AQAAAAEAACcQAAAAEHaokFSQfSdGGvBVycxbIisPWBVc8fduSY8OsMUjgWIywrhOxl+RcfRlWTDN/Giejg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Vehicle");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WishList",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Topic",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Message",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58da6082-c964-4048-a51f-3e800c02d98e", "AQAAAAEAACcQAAAAEJ6kDbGMfcviHoVYGUxlXOeQv4MohvlzCsMm2Kh7gq7XL/UrPwURV+lCCOFN8SW+vw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ed269e0-5977-4f06-8a55-8d62e2f821ed", "AQAAAAEAACcQAAAAEJU2WIO4umGplct+bwYd8h0fqiDcND1hSYQuRM0+8aE514Byv2k/y9wyY+WdVKu1yQ==" });
        }
    }
}
