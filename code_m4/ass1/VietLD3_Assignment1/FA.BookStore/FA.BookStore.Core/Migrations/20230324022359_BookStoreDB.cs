using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.BookStore.Core.Migrations
{
    public partial class BookStoreDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActice = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "abc", "abc" },
                    { 2, "vcd", "vcd" },
                    { 3, "dfr", "dfg" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "p1", "p1" },
                    { 2, "p2", " p2" },
                    { 3, "p3", "p3" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "AuthorId", "CategoryId", "CreateDate", "ImgUrl", "IsActive", "ModifiedDate", "Price", "PublisherId", "Quantity", "Summary", "Title" },
                values: new object[] { 1, 1, 3, new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7316), "", true, new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7339), 100000.0, 1, 2, "b1", "b1" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "AuthorId", "CategoryId", "CreateDate", "ImgUrl", "IsActive", "ModifiedDate", "Price", "PublisherId", "Quantity", "Summary", "Title" },
                values: new object[] { 2, 2, 2, new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7344), "", true, new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7345), 100000.0, 2, 4, "b2", "b2" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "AuthorId", "CategoryId", "CreateDate", "ImgUrl", "IsActive", "ModifiedDate", "Price", "PublisherId", "Quantity", "Summary", "Title" },
                values: new object[] { 3, 2, 1, new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7348), "", false, new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7349), 100000.0, 3, 4, "b3", "b3" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "BookId", "Content", "CreatedDate", "IsActice" },
                values: new object[,]
                {
                    { 1, 1, "c1", new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7456), true },
                    { 2, 2, "c2", new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7460), true },
                    { 3, 3, "c3", new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7462), true },
                    { 4, 3, "c4", new DateTime(2023, 3, 24, 9, 23, 59, 538, DateTimeKind.Local).AddTicks(7463), true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BookId",
                table: "Comments",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
