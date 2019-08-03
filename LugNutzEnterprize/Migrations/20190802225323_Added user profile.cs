using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class Addeduserprofile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d84d538-9727-473b-b0b3-f804b8a48273", "AQAAAAEAACcQAAAAEM0d4WCU1ODDyb7Za26kXRK+BYW7NrIOgZsSOxj5P7IGwG3NyALkXnujxJxw5nKmqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf5c4a50-3293-4103-8223-957eaf908bdc", "AQAAAAEAACcQAAAAEL3gpDvW88aMBt57H/j1R9vT53mZTnMzWexeoBnB2mwsy26GQHAxGy3AOPhuD8474w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

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
