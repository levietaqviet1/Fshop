using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class db7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 21, 14, 59, 53, 696, DateTimeKind.Local).AddTicks(3787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 21, 9, 47, 56, 676, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21811bcb-fae8-4c00-9c33-de997d4e8107",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f356b707-8cf9-4d7a-8a1c-f8520f4bd2d9", "989e17ef-25ad-4d8a-b8fd-d06683873ae7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8cc0c6b6-a879-4191-8a70-a704ea07a88e", "c1a64e17-9a25-4f04-a0ca-1cdd9a83b740" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6acb348-68a6-4bfc-953b-8c31111e072b", "cc320977-995f-461b-8f0f-ab959d548b8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f820953d-2368-46d5-ad31-f1e1f6d0e044", "e3242e73-d992-4057-a1eb-fa887eacabb1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 2147483647);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 21, 9, 47, 56, 676, DateTimeKind.Local).AddTicks(9924),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 21, 14, 59, 53, 696, DateTimeKind.Local).AddTicks(3787));

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
        }
    }
}
