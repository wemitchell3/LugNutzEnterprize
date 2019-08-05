using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class TimeStamp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "327b1101-7219-4207-b922-565c9e857077", "AQAAAAEAACcQAAAAEBNe/sAOv7e2HRUf6lbHavqi8JMI0CgrK8jH1J8atqAM6tdl76rTLPoTSKOkbgzCZw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dbe66281-bd7a-4289-b1d9-2232217084e6", "AQAAAAEAACcQAAAAEPkya3Wxg58rBRQW4qaL1ZQM1tka03fDe0xwyUeIPEB1ToRyOCpcX2JALSNN1yQXKA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d48193af-31fc-4a26-b040-3ae0adbfb609", "AQAAAAEAACcQAAAAELZjkur2vvmdc6Lg7CRBOChBBG0xFe1Y5k37Gf5Dl4146J5fZpLkZubxg5zceAsxqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55ed0344-a69d-4b13-a5a2-eff7a5142cf8", "AQAAAAEAACcQAAAAEPbF8BtbvuICD5/Iw9FZkDXf1ucLG0PaPJ/DlY9JRlRFZxshcoKKfowk0XRtlrgPkw==" });
        }
    }
}
