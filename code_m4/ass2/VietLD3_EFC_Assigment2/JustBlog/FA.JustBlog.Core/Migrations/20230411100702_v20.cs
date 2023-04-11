using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class v20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 17, 7, 2, 350, DateTimeKind.Local).AddTicks(1526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 10, 11, 9, 3, 548, DateTimeKind.Local).AddTicks(8604));

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

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 10m, 25m, 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 200m, 250m, 50 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 200m, 300m, 60 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 300m, 450m, 90 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 10, 11, 9, 3, 548, DateTimeKind.Local).AddTicks(8604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 17, 7, 2, 350, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20b578f9-0dab-4665-b252-a3ebefa78641", "4020d767-691a-4cdb-bd51-acb048fc958c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42d3d9d1-2329-496a-92b3-a042d0e9e822", "01c1b664-7eda-43d2-bdaf-c6c9ecbcb5fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5550e16-af6c-477f-8a3a-1efd76c19672", "2d1c4278-2304-48e1-b873-3df8c50cd528" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 0m, 0m, 0 });
        }
    }
}
