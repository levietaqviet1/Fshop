using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class db100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e94a9bca-5a7a-4806-b8cd-97e9075ff13a", "21842bcb-fae8-4c00-9c33-de997d4e8103" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db5782c7-bf14-41f7-bc1f-950128ecb3bb", "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" });

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 17, 14, 48, 2, 954, DateTimeKind.Local).AddTicks(3801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 12, 10, 12, 51, 745, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db1782c7-bf14-41f7-bc1f-950128ecb3bd", "b11bbed6-4919-4f52-a4b1-c45091a8fbf0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "db5782c7-bf14-41f7-bc1f-950128ecb3bb", "21842bcb-fae8-4c00-9c33-de997d4e8103" },
                    { "e94a9bca-5a7a-4806-b8cd-97e9075ff13a", "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1da7633-01f9-449b-bc93-2706d182be3d", "aed6a5ca-0851-45e9-933f-d60e111afe5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "453116f7-56b1-4e4e-90a8-a54aa5c9744e", "9eb21e5e-64f0-40e4-9de5-414a2e21e0cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e341911e-55f6-43a1-bec2-ab6788e08ce9", "35de9e2c-2fdb-458d-ab64-29659b782721" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "21811bcb-fae8-4c00-9c33-de997d4e8107", 0, "ad73ad03-0acf-44fe-8e1c-af46fb8de6a9", "vietUser@gmail.com", true, "Viet", "User", false, null, "VIETUSER@GMAIL.COM", "VIETUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEGf8AICmlUDtMuw9p1TPGYB0/OH8X60Ud06sUakpWa+Tpu2IJAZvF6Ht7DxsYeWEjA==", "0922556369", true, "6bb75a80-1c32-4144-9615-1da40ca4a74b", false, "vietUser.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "db1782c7-bf14-41f7-bc1f-950128ecb3bd", "21811bcb-fae8-4c00-9c33-de997d4e8107" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "db1782c7-bf14-41f7-bc1f-950128ecb3bd", "b0446349-235d-4b0f-a8e9-87382a82923f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db1782c7-bf14-41f7-bc1f-950128ecb3bd", "21811bcb-fae8-4c00-9c33-de997d4e8107" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db5782c7-bf14-41f7-bc1f-950128ecb3bb", "21842bcb-fae8-4c00-9c33-de997d4e8103" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e94a9bca-5a7a-4806-b8cd-97e9075ff13a", "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db1782c7-bf14-41f7-bc1f-950128ecb3bd", "b0446349-235d-4b0f-a8e9-87382a82923f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db1782c7-bf14-41f7-bc1f-950128ecb3bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21811bcb-fae8-4c00-9c33-de997d4e8107");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 12, 10, 12, 51, 745, DateTimeKind.Local).AddTicks(1199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 17, 14, 48, 2, 954, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e94a9bca-5a7a-4806-b8cd-97e9075ff13a", "21842bcb-fae8-4c00-9c33-de997d4e8103" },
                    { "db5782c7-bf14-41f7-bc1f-950128ecb3bb", "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ee97baa-7cc7-420a-85c5-fbf07102c3d6", "de650c85-58cd-48b5-8536-529db879f6b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "184cd4ad-15bd-4aec-b007-54e2bc700cee", "3ee6eb86-ebe1-4c16-8c80-3b0d7fe43482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "989c7fe9-ff81-4c6a-bda2-4b6b0f06ff2e", "c57fd1ed-04b3-47ff-b082-cfe9ae3e9fa6" });
        }
    }
}
