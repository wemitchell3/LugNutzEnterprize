using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class WishList2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishList_AspNetUsers_UserId",
                table: "WishList");

            migrationBuilder.DropIndex(
                name: "IX_WishList_UserId",
                table: "WishList");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "WishList");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "WishList",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_WishList_UserId",
                table: "WishList",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_AspNetUsers_UserId",
                table: "WishList",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
