using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 21, 9, 38, 8, 793, DateTimeKind.Local).AddTicks(3719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 20, 18, 20, 44, 705, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21811bcb-fae8-4c00-9c33-de997d4e8107",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bbdec0e1-a804-40a6-88db-11dfb8d2a1ea", "b4c89139-404b-40d2-ad9c-da5a7b7eb15b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb649b08-c4ff-4eef-82ab-e1a6d8e1aeda", "05ae168d-0696-418c-9ca6-cc4e7984d258" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "565dd535-8c52-45d4-bf1b-68cf6de06535", "42d7b542-48d0-447e-85be-0074649ba649" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87e686e3-7b02-4737-99d8-c0b3d7ee3923", "04457550-04fd-4d05-86ae-a5ce2dcb85ea" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 20, 18, 20, 44, 705, DateTimeKind.Local).AddTicks(4637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 21, 9, 38, 8, 793, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21811bcb-fae8-4c00-9c33-de997d4e8107",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16592b57-a004-4f74-952d-df564ea03afd", "5520acec-39da-4f6b-b46a-09b3f2d08d14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9db67f21-3168-4c72-a854-0465201a0740", "21de7b62-4919-4ab9-a220-f2190e942081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "623097e3-974b-4347-9889-19585f670e20", "de71a3f7-442a-4a3e-9c77-eb7110ec6dfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bfb69d29-09d8-4470-99ec-1cba9a3c4b48", "ddc0fa40-b5e6-4208-8c4d-3590a75d6b8a" });
        }
    }
}
