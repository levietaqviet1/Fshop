using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class DBJustBlog2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsingIdentityUserId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UsingIdentityUserId1",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 5, 14, 10, 1, 917, DateTimeKind.Local).AddTicks(4218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 5, 14, 3, 59, 40, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.AddColumn<int>(
                name: "UsingIdentityUserId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UsingIdentityUserId1",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UsingIdentityUserId1",
                table: "Posts",
                column: "UsingIdentityUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UsingIdentityUserId1",
                table: "Comments",
                column: "UsingIdentityUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UsingIdentityUserId1",
                table: "Comments",
                column: "UsingIdentityUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_UsingIdentityUserId1",
                table: "Posts",
                column: "UsingIdentityUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UsingIdentityUserId1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_UsingIdentityUserId1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UsingIdentityUserId1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UsingIdentityUserId1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UsingIdentityUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UsingIdentityUserId1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UsingIdentityUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UsingIdentityUserId1",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 5, 14, 3, 59, 40, DateTimeKind.Local).AddTicks(8051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 5, 14, 10, 1, 917, DateTimeKind.Local).AddTicks(4218));
        }
    }
}
