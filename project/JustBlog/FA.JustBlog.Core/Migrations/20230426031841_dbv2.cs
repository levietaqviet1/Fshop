using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class dbv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 26, 10, 18, 41, 283, DateTimeKind.Local).AddTicks(4751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 22, 3, 26, 56, 246, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21811bcb-fae8-4c00-9c33-de997d4e8107",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67605916-c60d-49ec-86f8-0369d8233c07", "b54b20f5-0068-4482-968b-dc871c2d5fac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9bee2a7e-5e14-46df-b116-11dc27df857e", "7db81a27-17ba-48ca-b7d9-a29835190c5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eec59d3d-9a59-47c9-9620-47cea27fd776", "5c8131eb-02b9-4b05-8835-a0c19496da4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f470bbb3-c6d8-4aa7-b501-0c1d2a5273f6", "fb44deae-a0bc-4f1a-8986-09e84ecb6144" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 22, 3, 26, 56, 246, DateTimeKind.Local).AddTicks(934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 26, 10, 18, 41, 283, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21811bcb-fae8-4c00-9c33-de997d4e8107",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4198e2a0-dd11-4c3b-a590-d9452dd08281", "d9160696-d154-49a0-a267-e291f2b330c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ac6b22c-0006-447e-b1e3-32466308af2d", "c2dbdcf2-7ce9-4981-8859-74d9c7e2677d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ac01d00-b972-4023-a9ce-656e0e2c30f7", "8904e5b5-a873-4c0b-be69-a67c4a5bf404" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "98b0cfb8-af06-48c5-8114-4b13fe59aeaa", "20f0bb84-def5-4046-ad12-249b44160b5f" });
        }
    }
}
