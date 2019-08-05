using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class PhotoUpload1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Vehicle",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Vehicle");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b35e20a0-6de9-4ccf-a2a1-3f7c9b75fce4", "AQAAAAEAACcQAAAAEJIhX36D/L1GCNmq88+ZGfqtbcJcz81AtSJcIMzTC1+bfAmk2kgTacfsLKqWwC6ygg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e1d195a-bc97-4826-ac54-3078257c3a90", "AQAAAAEAACcQAAAAEHO+i4E3smdjmzd8yyA0RS93I1isiCbCNbblTSnFe+6Xwx2ePtXh8iLeoViBneMGfg==" });
        }
    }
}
