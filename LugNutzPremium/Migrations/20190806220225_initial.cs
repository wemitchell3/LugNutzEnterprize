using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzPremium.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TopicName",
                table: "Message",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TopicId",
                table: "Message",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8a06700-d08e-4b17-b3ac-794483ff30c3", "AQAAAAEAACcQAAAAEL2LzJnAdSwbsK2dCklcUgO5rQHzVdwTZCagExWh8pPmt6U5z7wM7LWX0ZPkbY3YZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3df857ea-061d-4238-b955-15e3a67ddf54", "AQAAAAEAACcQAAAAEDcRXEPUcYaIHhX15v0xaUcEbDcF6UU0EwTACUEMWQEY+rg9qTIHMdecr9Qnx+neOw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TopicName",
                table: "Message",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TopicId",
                table: "Message",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d774a3b9-fe07-4696-bbb8-8c380b5ce550", "AQAAAAEAACcQAAAAEEYHvwpUnMwztteP3VHWV6KQ+BHKHiEnkRylAY2EVbzTmkJ9JaiLfDjrW/Dy4kEbrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4262351-5620-4ef9-af78-bc3acaf7fa72", "AQAAAAEAACcQAAAAELP2WGmuWTdQ9eR9tmE3j54cOZZoohrw9nUPb1dc7iPMx1x494PZUIdwIyDVdPTquA==" });
        }
    }
}
