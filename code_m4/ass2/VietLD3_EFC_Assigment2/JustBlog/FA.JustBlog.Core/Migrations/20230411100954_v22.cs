using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class v22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 17, 9, 54, 293, DateTimeKind.Local).AddTicks(4804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 17, 8, 30, 180, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac1d717e-8b1e-47e2-9ead-82dcf8a0bdf6", "524f2128-611a-4547-a8bc-ca2e35d2192a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2fef6d1-7dd4-423d-b0d3-2020b667b2f4", "7c560032-c7b6-4bbc-b73c-1b0666a93241" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6b6f9351-eea7-417d-b991-8d94435d348d", "458927c7-17ab-43ae-bd63-c134df9ea240" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rate",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rate",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Rate",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Rate",
                value: 300m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 17, 8, 30, 180, DateTimeKind.Local).AddTicks(6779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 17, 9, 54, 293, DateTimeKind.Local).AddTicks(4804));

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

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rate",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rate",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Rate",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Rate",
                value: 0m);
        }
    }
}
