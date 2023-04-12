using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class DB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 12, 10, 12, 51, 745, DateTimeKind.Local).AddTicks(1199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 12, 9, 55, 59, 52, DateTimeKind.Local).AddTicks(4062));

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

            migrationBuilder.InsertData(
                table: "PostTagMap",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "Rate", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "UsingIdentityUserId", "ViewCount" },
                values: new object[,]
                {
                    { 5, 2, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Add	Added entity type	Adds the given entity to the context with the Added state. When the changes are saved, the entities in the Added states are inserted into the database. After the changes are saved, the object state changes to Unchanged.\r\n\r\nExample:\r\ndbcontext.Students.Add(studentEntity)", new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5555555555555555555555555556m, 250m, "The DbSet class represents an entity set that can be used for create, read, update, and delete operations.\r\n\r\nThe context class (derived from DbContext) must include the DbSet type properties for the entities which map to database tables and views.", "DbSet in Entity Framework 6", 450m, "dbset-in-entity-framework-6", "21842bcb-fae8-4c00-9c33-de997d4e8103", 90 },
                    { 6, 2, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the Entity Framework, there are two persistence scenarios to save an entity data: connected and disconnected. In the connected scenario, the same instance of DbContext is used in retrieving and saving entities, whereas this is different in the disconnected scenario. In this chapter, you will learn about saving data in the connected scenario.", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8m, 360m, "Saving entity data in the connected scenario is a fairly easy task because the context automatically tracks the changes that happened on the entity during its lifetime.\r\n\r\nHere, we will use the same EDM for CRUD operations which we created in the Create Entity Data Model chapter. An entity which contains data in its scalar property will be either inserted, updated or deleted, based on its EntityState.", "Saving Data in the Connected Scenario", 450m, "saving-data-in-the-connected-scenario", "21842bcb-fae8-4c00-9c33-de997d4e8103", 90 },
                    { 7, 2, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Language-Integrated Query (LINQ) is a powerful query language introduced in Visual Studio 2008. As the name suggests, LINQ-to-Entities queries operate on the entity set (DbSet type properties) to access the data from the underlying database. You can use the LINQ method syntax or query syntax when querying with EDM. Visit LINQ Tutorials to learn LINQ step-by-step.", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.6m, 300m, "You can build and execute queries using Entity Framework to fetch the data from the underlying database. EF 6 supports different types of queries which in turn convert into SQL queries for the underlying database.", "Querying in Entity Framework", 500m, "querying-in-entity-framework", "21842bcb-fae8-4c00-9c33-de997d4e8103", 100 },
                    { 8, 2, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SELECT TOP (1) \r\n[Extent1].[StudentID] AS [StudentID], \r\n[Extent1].[StudentName] AS [StudentName], \r\n[Extent2].[StandardId] AS [StandardId], \r\n[Extent2].[StandardName] AS [StandardName], \r\n[Extent2].[Description] AS [Description]\r\nFROM  [dbo].[Student] AS [Extent1]\r\nLEFT OUTER JOIN [dbo].[Standard] AS [Extent2] ON [Extent1].[StandardId] = [Extent2].[StandardId]\r\nWHERE 'Bill' = [Extent1].[StudentName]", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.6666666666666666666666666667m, 3000m, "Eager loading is the process whereby a query for one type of entity also loads related entities as part of the query, so that we don't need to execute a separate query for related entities. Eager loading is achieved using the Include() method.", "Eager Loading in Entity Framework", 4500m, "eager-loading-in-entity-framework", "21842bcb-fae8-4c00-9c33-de997d4e8103", 900 },
                    { 9, 2, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "We can disable lazy loading for a particular entity or a context. To turn off lazy loading for a particular property, do not make it virtual. To turn off lazy loading for all entities in the context, set its configuration property to false.", new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.6666666666666666666666666667m, 300m, "Lazy loading is delaying the loading of related data, until you specifically request for it. It is the opposite of eager loading. For example, the Student entity contains the StudentAddress entity. In the lazy loading, the context first loads the Student entity data from the database, then it will load the StudentAddress entity when we access the StudentAddress property as shown below.", "Lazy Loading in Entity Framework", 450m, "lazy-loading-in-entity-framework", "21842bcb-fae8-4c00-9c33-de997d4e8103", 90 },
                    { 10, 2, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Here, we are going to create an Entity Data Model (EDM) for an existing database in database-first approach and understand the basic building blocks.    Entity Framework uses EDM for all the database-related operations. Entity Data Model is a model that describes entities and the relationships between them. Let's create a simple EDM for the School database using Visual Studio (2012\\2015\\2017) and Entity Framework 6.", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.6666666666666666666666666667m, 300m, "Here, we are going to create an Entity Data Model (EDM) for an existing database in database-first approach and understand the basic building blocks.    Entity Framework uses EDM for all the database-related operations. Entity Data Model is a model that describes entities and the relationships between them. Let's create a simple EDM for the School database using Visual Studio (2012\\2015\\2017) and Entity Framework 6.", "Explicit Loading in Entity Framework", 450m, "explicit-loading-in-entity-framework", "21842bcb-fae8-4c00-9c33-de997d4e8103", 90 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMap",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 12, 9, 55, 59, 52, DateTimeKind.Local).AddTicks(4062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 12, 10, 12, 51, 745, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21842bcb-fae8-4c00-9c33-de997d4e8103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b9383f00-05a6-4a49-b492-a163e9da2f97", "550be5cf-bb74-4783-88d7-b5b00e37bd75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37c6829e-7a66-4716-ac55-88d23c44ae04", "644dd5c6-be56-457e-9637-1a5f80ce54f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0446349-235d-4b0f-a8e9-87382a82923f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8ac3102-c527-4ac7-985b-c87667d8f3b9", "569799ef-b5d2-40a5-a257-6bddf8f72011" });
        }
    }
}
