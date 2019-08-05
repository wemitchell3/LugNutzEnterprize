using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class profileImage1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e07583b-1459-47af-b1cd-56c82941e616", "AQAAAAEAACcQAAAAEHAZX/GpLMBssikKMJ6veWUf3ktWwIwXlEcpbhuF14pDhnCq/XZHO21yGeU72AAZCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c05fce85-a955-405f-b516-c3d035f8d900", "AQAAAAEAACcQAAAAEN0QrOiyIYRmVkL+PeTUd3/LgGkj+ZylpnTVe5oKXwwTYOLLbA/EiIwJdUOztUUwqg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ce6fef4-975b-4f25-9b54-edba0d9eb722", "AQAAAAEAACcQAAAAEJMaJr8aO6YCNglYeyBFgLoYDTb43NIW/+EMARVwA/K+jviPUBT3QpiJaGcY+QmNxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8005af8f-287a-4113-ab1f-c5a8427ac369", "AQAAAAEAACcQAAAAEFzm9DBhdlisoQEJ7FZ9GW18MVXojt3rSJsY2yGgciOmDLyRueHYBhmuwKSbPol8qA==" });
        }
    }
}
