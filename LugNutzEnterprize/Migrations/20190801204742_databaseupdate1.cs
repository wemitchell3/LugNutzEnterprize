using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class databaseupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b62dd71-1bb3-4bcc-bb2d-ce466f29eb65", "AQAAAAEAACcQAAAAEEqEZ6eNA9btWiGTEbGOo7aOYdHVsr8fEp1QYXKTK6P7OpTcVSPMr31GvPgIw7fixw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0d13f81-58bf-4cb5-94da-da29a9d4c5d6", "AQAAAAEAACcQAAAAEPRvWfkjGfDAac6s1sctTKktK/MEbPpUejdVzuX+OcUcmgFSfzj2ewdnDHEm6CwfNw==" });
        }
    }
}
