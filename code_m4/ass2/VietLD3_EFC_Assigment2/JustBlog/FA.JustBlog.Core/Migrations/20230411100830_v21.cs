using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class v21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 17, 8, 30, 180, DateTimeKind.Local).AddTicks(6779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 17, 7, 2, 350, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ea66bac-2680-4e12-b57b-b51de8e9bec1", "27f7ebb7-61ae-4cba-9cf2-4ad90e79a5f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26fde9db-076a-4796-b14a-a87a128ec02c", "b080092c-0992-4270-a605-1cabafcc0e62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ded7b419-a8a6-48d3-b16e-d1bb547a2bbd", "16d1ea2f-d078-489c-8ef5-0b5299428d78" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 17, 7, 2, 350, DateTimeKind.Local).AddTicks(1526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 17, 8, 30, 180, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdcd789c-93b9-4fd1-83f9-8e33bd5110fb", "6f870811-b9cf-45d5-b339-2c98cc618a7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "529457e7-60eb-48ae-a1d8-4eb36a86a574", "d9f392b9-12a9-4f67-ad56-f0ef1a0bc5b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5bec2231-f7d0-4240-8b0e-d2a5271976a5", "a1de2cc7-9cf7-48a6-ba30-0213e073dc41" });
        }
    }
}
