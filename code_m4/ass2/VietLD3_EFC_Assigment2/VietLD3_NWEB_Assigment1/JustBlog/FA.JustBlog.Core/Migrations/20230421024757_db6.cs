using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class db6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 21, 9, 47, 56, 676, DateTimeKind.Local).AddTicks(9924),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 21, 9, 46, 1, 429, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21811bcb-fae8-4c00-9c33-de997d4e8107",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1d75028-612a-41b8-bcf7-c189a2ca4e18", "4dc038e1-93b2-470a-b70c-b33b45c9631f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79674562-5f8e-4229-9f39-94d3ee4ecf96", "9c4ce388-c3ed-42ad-863a-3f2c88659ed2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c2f8b23-eb77-4ab7-9b35-2261236b1041", "3bfef2c0-c6ec-45a9-8372-ce463bb7b053" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "726602d7-8b64-42a9-aa4f-fcdcf3812c98", "6c53d207-694d-45d5-a4bf-dce87c819087" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Entity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is \r\n\r\nEntity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is \r\n\r\nEntity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is \r\n\r\nEntity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work  ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 21, 9, 46, 1, 429, DateTimeKind.Local).AddTicks(9046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 21, 9, 47, 56, 676, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21811bcb-fae8-4c00-9c33-de997d4e8107",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dc411d6d-b3d8-4861-a774-6f2e1c5af78e", "98504607-353d-4d6f-a824-05d074971fa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4665f292-e4e4-41b6-86ba-a7b33b2f8107", "e90eba66-d0e7-4b6c-a5b2-d53eb75d40bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20c072be-2f68-450e-bece-83be207f0d38", "1def6ddb-14cc-4b2a-b7b4-49086253ac8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22bfcc87-2ca1-4775-a768-4cc8be2c00c3", "384f146d-9bd0-4eab-a496-c8db6700e486" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "What is Entity Framework?");
        }
    }
}
