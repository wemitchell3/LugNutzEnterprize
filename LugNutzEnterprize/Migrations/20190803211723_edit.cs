using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3f831ae-b7a7-4080-b618-44e6e54747c4", "AQAAAAEAACcQAAAAEGAOpju9TnyXzDJ/Duql6oYtdOvGuKpDAbryQ8ql6k7gt02uveSleBYT9FkFZFiiJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55c98ee7-9ccc-492b-966c-90e674c1d5eb", "AQAAAAEAACcQAAAAEJ9EJibSNsuCFNxA6mfFiDXZxChY3s1OlMdFFKYiLSck3EMTIP4XsdFvqddC1Lsv5Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ed30f36-9c61-4bd9-b302-12796843fe7b", "AQAAAAEAACcQAAAAEKsYT3MfNA1MBbg1kLPDx+eFoCTOfA2bTrkyf2ChH1a8e+SHK7fOiWHitxNCWgmdiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aaf176c4-8c64-42e2-b9c0-d3ccbb2d603c", "AQAAAAEAACcQAAAAELceF79QvTSIjyEzHXe9sn6Q0o9Jrgzbh6c1F/6PTxc1K6i8AywDHCC8xogBkw9kSQ==" });
        }
    }
}
