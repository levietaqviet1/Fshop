using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class DBJustBlog4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 6, 16, 44, 26, 505, DateTimeKind.Local).AddTicks(336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 6, 16, 40, 27, 492, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff407c6e-30d7-42e3-a5c8-1855cc1c9d94", "95830ee2-7ffa-46ad-8cf7-07d1fa6a83d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd750f92-250b-4442-9400-38730ddcc6e0", "67067f03-c389-4a22-bef1-1b0e744926df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc48f996-b6c5-443e-8c7f-0a034e5989e7", "25014ce9-f9ce-4670-8322-d578642dd05f" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentHeader", "CommentText" },
                values: new object[] { "tai sao m vô lý thế", "Sao bạn lại đăng thế thế" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentHeader", "CommentText", "PostId", "UsingIdentityUserId" },
                values: new object[,]
                {
                    { 3, "tai sao cho điểm thấp", "Sao bạn lại đăng thế kém z", 2, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 4, "tai sao hả", "Sao bạn lại đăng thế hả", 3, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 5, "tai sao ??????", "Sao bạn lại đăng thế chứ", 3, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 6, "why", "Fuck", 3, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 7, "Woww", "Xinj quas", 3, "21842bcb-fae8-4c00-9c33-de997d4e8103" },
                    { 8, "!0 diem", "te qua", 3, "21842bcb-fae8-4c00-9c33-de997d4e8103" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 6, 16, 40, 27, 492, DateTimeKind.Local).AddTicks(9005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 6, 16, 44, 26, 505, DateTimeKind.Local).AddTicks(336));

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

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentHeader", "CommentText" },
                values: new object[] { "tai sao", "Sao bạn lại đăng thế" });
        }
    }
}
