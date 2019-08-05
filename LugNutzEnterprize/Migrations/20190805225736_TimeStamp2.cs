using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class TimeStamp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MaintenanceTask",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8beec900-f326-4079-859f-cf76f34e08d7", "AQAAAAEAACcQAAAAEHFnTze04wMrnXWjWgFBTT2ifviRbyeR+fNIyonOuiueLiZLYb1YxhDO+VCdzlZdNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85d665d7-58a4-4315-a538-e55190b61a29", "AQAAAAEAACcQAAAAEEBQ5MFqVuVEhXkxHY8VEuASoDoFVPsfEGt/n+fL+8VJ6KyVrz4M0oU18JaJTvH3YQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MaintenanceTask",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0ea9d2c-3a0f-433e-9dcb-3a270aa2c001", "AQAAAAEAACcQAAAAEKFpZzOXGY0naxGe5rftAhGCvIoiEwx2s19uLiH/Qa8JexXyu7TJ6qkmeH2uwWcCxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3b698cb-719f-4538-bcb2-c84cc7749d4f", "AQAAAAEAACcQAAAAEBt2LhL+Iwopm2arcQJaQOKB+RoxRn8pKQexoa8Cc9/dcaf8f0XF02mvgrVfM+keKw==" });
        }
    }
}
