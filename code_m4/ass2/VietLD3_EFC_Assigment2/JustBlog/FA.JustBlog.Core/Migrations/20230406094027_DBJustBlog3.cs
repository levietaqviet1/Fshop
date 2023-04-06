using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class DBJustBlog3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 6, 16, 40, 27, 492, DateTimeKind.Local).AddTicks(9005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 6, 16, 35, 43, 938, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9da7ec05-fb2c-4e42-8386-f90cf9311175", "62e0c0fe-254a-451f-b2fd-db09b0c35df9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ecc7ef4-cf52-4511-a10b-47254089a503", "f1f83173-7b47-4938-b98a-1737c403150b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7edc7e4-d275-4e90-8979-eea19eba6a1e", "f7878d3c-d63f-4667-8297-5e006305cbef" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentHeader", "CommentText", "PostId", "UsingIdentityUserId" },
                values: new object[,]
                {
                    { 1, "tai sao", "Sao bạn lại đăng thế", 1, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 2, "tai sao", "Sao bạn lại đăng thế", 1, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 6, 16, 35, 43, 938, DateTimeKind.Local).AddTicks(3311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 6, 16, 40, 27, 492, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "497966f9-fe7f-4fbb-9788-866dd9d6dd0f", "4c7bf309-1959-4a2d-94a3-8d8afed98790" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7dc4ca4d-0dda-4b24-9183-a7f47b64fe43", "88a83a7b-fb03-4fb8-b837-d7243dd9ea34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "561f61e6-9ba4-4d39-bcf5-ca25ba43c921", "58c86116-b707-4c4b-ad38-086c2b54651f" });
        }
    }
}
