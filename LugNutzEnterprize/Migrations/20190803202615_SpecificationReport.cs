using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class SpecificationReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b957d0f-e124-4742-85fc-855f7bb50e47", "AQAAAAEAACcQAAAAENk2/vvr7SHflBN1C7IwgawjJhdyuNb9VGruN0CeaGP5+sSangdMHhEXdGEqgxPjqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "52b73cc8-e62a-4811-a4e4-b24e22331dee", "AQAAAAEAACcQAAAAEHVR8qn111qus+U/ukmUgZ8vqKygIVwjt6Dt519YYIeL5z7/x1IYCMMYPld/+FwWAQ==" });
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
