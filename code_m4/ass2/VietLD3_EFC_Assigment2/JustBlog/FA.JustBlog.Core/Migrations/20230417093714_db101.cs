using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class db101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 17, 16, 37, 13, 596, DateTimeKind.Local).AddTicks(3600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 17, 14, 48, 2, 954, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21811bcb-fae8-4c00-9c33-de997d4e8107",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "308ea6d0-3fbd-4a02-8242-f15caa4f8356", "a4d834a9-8c02-4b18-9fc1-2158620b349a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90badfde-c2cf-44ae-9749-e6d75472f370", "cb1db7cb-33d7-42d1-8f1d-1c69ebe6f70c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d6e8a26-1ac5-4a4a-a6c6-da1f8e23d6a0", "2fa1337f-32b3-4078-b650-1decf9470b37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2607a386-1e9c-4812-abda-5926e8629430", "f50735fd-3006-4b33-b158-f61aadd38582" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "Rate", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "UsingIdentityUserId", "ViewCount" },
                values: new object[] { 11, 2, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Language-Integrated Query (LINQ) is a powerful query language introduced in Visual Studio 2008. As the name suggests, LINQ-to-Entities queries operate on the entity set (DbSet type properties) to access the data from the underlying database. You can use the LINQ method syntax or query syntax when querying with EDM. Visit LINQ Tutorials to learn LINQ step-by-step.", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.6m, 300m, "You can build and execute queries using Entity Framework to fetch the data from the underlying database. EF 6 supports different types of queries which in turn convert into SQL queries for the underlying database.", "Querying in Entity Core", 500m, "querying-in-entity-core", "21842bcb-fae8-4c00-9c33-de997d4e8103", 100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 17, 14, 48, 2, 954, DateTimeKind.Local).AddTicks(3801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 17, 16, 37, 13, 596, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21811bcb-fae8-4c00-9c33-de997d4e8107",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad73ad03-0acf-44fe-8e1c-af46fb8de6a9", "6bb75a80-1c32-4144-9615-1da40ca4a74b" });

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
        }
    }
}
