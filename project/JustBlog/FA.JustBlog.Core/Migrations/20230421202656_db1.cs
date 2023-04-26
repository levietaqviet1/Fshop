using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    PostContent = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ViewCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    RateCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    TotalRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UsingIdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UsingIdentityUserId",
                        column: x => x.UsingIdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentHeader = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CommentTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 4, 22, 3, 26, 56, 246, DateTimeKind.Local).AddTicks(934)),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UsingIdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UsingIdentityUserId",
                        column: x => x.UsingIdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTagMap",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTagMap", x => new { x.TagId, x.PostId });
                    table.ForeignKey(
                        name: "FK_PostTagMap_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTagMap_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "db1782c7-bf14-41f7-bc1f-950128ecb3bd", "b11bbed6-4919-4f52-a4b1-c45091a8fbf0", "User", "USER" },
                    { "db5782c7-bf14-41f7-bc1f-950128ecb3bb", "b31bbed6-4919-4f52-a4b1-c45091a8fbf0", "Blog Owner", "BLOG OWNER" },
                    { "e94a9bca-5a7a-4806-b8cd-97e9075ff13a", "e22ebaa4-db51-4cb3-8f37-ad4ba73b0e1e", "Contributor", "CONTRIBUTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "21811bcb-fae8-4c00-9c33-de997d4e8107", 0, "4198e2a0-dd11-4c3b-a590-d9452dd08281", "vietUser@gmail.com", true, "Viet", "User", false, null, "VIETUSER@GMAIL.COM", "VIETUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEGf8AICmlUDtMuw9p1TPGYB0/OH8X60Ud06sUakpWa+Tpu2IJAZvF6Ht7DxsYeWEjA==", "0922556369", true, "d9160696-d154-49a0-a267-e291f2b330c0", false, "vietUser.com" },
                    { "21842bcb-fae8-4c00-9c33-de997d4e8103", 0, "9ac6b22c-0006-447e-b1e3-32466308af2d", "vietBlogOwner@gmail.com", true, "Khi", "nguyen", false, null, "VIETBLOGOWNER@GMAIL.COM", "VIETBLOGOWNER@GMAIL.COM", "AQAAAAEAACcQAAAAEGf8AICmlUDtMuw9p1TPGYB0/OH8X60Ud06sUakpWa+Tpu2IJAZvF6Ht7DxsYeWEjA==", "045896589", true, "c2dbdcf2-7ce9-4981-8859-74d9c7e2677d", false, "vietBlogOwner@gmail.com" },
                    { "97571dcc-079e-4c3a-ba9b-bbde3d03a03d", 0, "4ac01d00-b972-4023-a9ce-656e0e2c30f7", "vietContributor@gmail.com", true, "Viet", "Le", false, null, "VIETCONTRIBUTOR@GMAIL.COM", "VIETCONTRIBUTOR@GMAIL.COM", "AQAAAAEAACcQAAAAEJ51SmQrANatorjKkODvG7wRz8i73uIAUIHAmXRldg8ikayfZiaDQvbSOuY+XFPiJQ==", "0985695635", true, "8904e5b5-a873-4c0b-be69-a67c4a5bf404", false, "vietContributor@gmail.com" },
                    { "b0446349-235d-4b0f-a8e9-87382a82923f", 0, "98b0cfb8-af06-48c5-8114-4b13fe59aeaa", "user@gmail.com", true, "Toan", "Nguyen", false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAED7S01cmZYmeJEKd7/wVP+HGOCSHbR/Xl2NRWyWTXB6JbwfXREcO2D908cRKtFG2Ag==", "0458796598", true, "20f0bb84-def5-4046-ad12-249b44160b5f", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "If you're completely new to Entity Framework, we recommend you to learn Entity Framework basics first and gradually move forward.", "EF Basics", "ef-basics" },
                    { 2, "If you want to use or currently Entity Framework 6.x with existing database then learn Entity Framework 6 Database-First Approach in this section.", "EF 6 DB-First", "ef-6-db-first" },
                    { 3, "If you are using DDD (Domain Driven Design) for your application then learn Entity Framework 6 Code-First Approach in this section.", "EF 6 Code-First", "ef-6-code-first" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Count", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, 1, "Querying in Entity Framework Core remains the same as in EF 6.x, with more optimized SQL queries and the ability to include C#/VB.NET functions into LINQ-to-Entities queries", "Querying in Entity Framework Core", "querying-in-ef-core" },
                    { 2, 2, "Entity Framework Core provides different ways to add, update, or delete data in the underlying database", "Entity Framework Core: Saving Data in Connected Scenario", "saving-data-in-connected-scenario-in-ef-core" },
                    { 3, 3, "Conventions are default rules using which Entity Framework builds a model based on your domain (entity) classes", "Conventions in Entity Framework Core", "conventions-in-ef-core" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "db1782c7-bf14-41f7-bc1f-950128ecb3bd", "21811bcb-fae8-4c00-9c33-de997d4e8107" },
                    { "db5782c7-bf14-41f7-bc1f-950128ecb3bb", "21842bcb-fae8-4c00-9c33-de997d4e8103" },
                    { "e94a9bca-5a7a-4806-b8cd-97e9075ff13a", "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { "db1782c7-bf14-41f7-bc1f-950128ecb3bd", "b0446349-235d-4b0f-a8e9-87382a82923f" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "Published", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "UsingIdentityUserId", "ViewCount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Entity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is stored. With the Entity Framework, developers can work at a higher level of abstraction when they deal with data.", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10m, " to save or retrieve application data from the underlying database. We used to open a connection to the database, create a DataSet to fetch or submit the data to the database, convert data from the DataSet to .NET objects or vice-versa to apply business rules. This was a cumbersome and error prone process.", "Entity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is \r\n\r\nEntity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is \r\n\r\nEntity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is \r\n\r\nEntity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work  ", 25m, "what-is-entity-framework", "97571dcc-079e-4c3a-ba9b-bbde3d03a03d", 5 },
                    { 2, 1, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Let's understand the above EF workflow: To insert data, add a domain object to a context and call the SaveChanges() method. EF API will build an appropriate INSERT command and execute it to the database.  To read data, execute the LINQ-to-Entities query in your preferred language (C#/VB.NET). EF API will convert this query into SQL query for the underlying relational database and execute it.", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 200m, "First of all, you need to define your model. Defining the model includes defining your domain classes, context class derived from DbContext, and configurations (if any). EF will perform CRUD operations based on your model.", "Basic Workflow in Entity Framework", 250m, "basic-workflow-in-entity-framework", "97571dcc-079e-4c3a-ba9b-bbde3d03a03d", 50 },
                    { 3, 2, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "EF 6 Database-First and Code-First Features Creating Entity Data Model from your existing database Querying data using LINQ Saving data Using existing stored procedures, views, and table-valued functions CRUD operations using stored procedures  Optimistic concurrency & transactions support Supports Spatial Data Types Connection resiliency  Asynchronous query and save  Code-based configuration  Database command logging  Database command interception  ", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 200m, "Welcome to Entity Framework 6 database-first tutorials section. Here, you will learn how to use Entity Framework 6 with the existing database of your application. It starts from creating an Entity Data Model from your existing database and it will show you how to save and query data using Entity Framework 6.x.", "Entity Framework 6 Introduction", 300m, "entity-framework-6-introduction", "97571dcc-079e-4c3a-ba9b-bbde3d03a03d", 60 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "UsingIdentityUserId", "ViewCount" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Here, we are going to create an Entity Data Model (EDM) for an existing database in database-first approach and understand the basic building blocks.    Entity Framework uses EDM for all the database-related operations. Entity Data Model is a model that describes entities and the relationships between them. Let's create a simple EDM for the School database using Visual Studio (2012\\2015\\2017) and Entity Framework 6.", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, "Here, we are going to create an Entity Data Model (EDM) for an existing database in database-first approach and understand the basic building blocks.    Entity Framework uses EDM for all the database-related operations. Entity Data Model is a model that describes entities and the relationships between them. Let's create a simple EDM for the School database using Visual Studio (2012\\2015\\2017) and Entity Framework 6.", "Creating an Entity Data Model", 450m, "creating-an-entity-data-model", "21842bcb-fae8-4c00-9c33-de997d4e8103", 90 },
                    { 5, 2, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Add	Added entity type	Adds the given entity to the context with the Added state. When the changes are saved, the entities in the Added states are inserted into the database. After the changes are saved, the object state changes to Unchanged.\r\n\r\nExample:\r\ndbcontext.Students.Add(studentEntity)", new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, "The DbSet class represents an entity set that can be used for create, read, update, and delete operations.\r\n\r\nThe context class (derived from DbContext) must include the DbSet type properties for the entities which map to database tables and views.", "DbSet in Entity Framework 6", 450m, "dbset-in-entity-framework-6", "21842bcb-fae8-4c00-9c33-de997d4e8103", 90 },
                    { 6, 2, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the Entity Framework, there are two persistence scenarios to save an entity data: connected and disconnected. In the connected scenario, the same instance of DbContext is used in retrieving and saving entities, whereas this is different in the disconnected scenario. In this chapter, you will learn about saving data in the connected scenario.", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 360m, "Saving entity data in the connected scenario is a fairly easy task because the context automatically tracks the changes that happened on the entity during its lifetime.\r\n\r\nHere, we will use the same EDM for CRUD operations which we created in the Create Entity Data Model chapter. An entity which contains data in its scalar property will be either inserted, updated or deleted, based on its EntityState.", "Saving Data in the Connected Scenario", 450m, "saving-data-in-the-connected-scenario", "21842bcb-fae8-4c00-9c33-de997d4e8103", 90 },
                    { 7, 2, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Language-Integrated Query (LINQ) is a powerful query language introduced in Visual Studio 2008. As the name suggests, LINQ-to-Entities queries operate on the entity set (DbSet type properties) to access the data from the underlying database. You can use the LINQ method syntax or query syntax when querying with EDM. Visit LINQ Tutorials to learn LINQ step-by-step.", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, "You can build and execute queries using Entity Framework to fetch the data from the underlying database. EF 6 supports different types of queries which in turn convert into SQL queries for the underlying database.", "Querying in Entity Framework", 500m, "querying-in-entity-framework", "21842bcb-fae8-4c00-9c33-de997d4e8103", 100 },
                    { 8, 2, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SELECT TOP (1) \r\n[Extent1].[StudentID] AS [StudentID], \r\n[Extent1].[StudentName] AS [StudentName], \r\n[Extent2].[StandardId] AS [StandardId], \r\n[Extent2].[StandardName] AS [StandardName], \r\n[Extent2].[Description] AS [Description]\r\nFROM  [dbo].[Student] AS [Extent1]\r\nLEFT OUTER JOIN [dbo].[Standard] AS [Extent2] ON [Extent1].[StandardId] = [Extent2].[StandardId]\r\nWHERE 'Bill' = [Extent1].[StudentName]", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, "Eager loading is the process whereby a query for one type of entity also loads related entities as part of the query, so that we don't need to execute a separate query for related entities. Eager loading is achieved using the Include() method.", "Eager Loading in Entity Framework", 4500m, "eager-loading-in-entity-framework", "21842bcb-fae8-4c00-9c33-de997d4e8103", 900 },
                    { 9, 2, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "We can disable lazy loading for a particular entity or a context. To turn off lazy loading for a particular property, do not make it virtual. To turn off lazy loading for all entities in the context, set its configuration property to false.", new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, "Lazy loading is delaying the loading of related data, until you specifically request for it. It is the opposite of eager loading. For example, the Student entity contains the StudentAddress entity. In the lazy loading, the context first loads the Student entity data from the database, then it will load the StudentAddress entity when we access the StudentAddress property as shown below.", "Lazy Loading in Entity Framework", 450m, "lazy-loading-in-entity-framework", "21842bcb-fae8-4c00-9c33-de997d4e8103", 90 },
                    { 10, 2, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Here, we are going to create an Entity Data Model (EDM) for an existing database in database-first approach and understand the basic building blocks.    Entity Framework uses EDM for all the database-related operations. Entity Data Model is a model that describes entities and the relationships between them. Let's create a simple EDM for the School database using Visual Studio (2012\\2015\\2017) and Entity Framework 6.", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, "Here, we are going to create an Entity Data Model (EDM) for an existing database in database-first approach and understand the basic building blocks.    Entity Framework uses EDM for all the database-related operations. Entity Data Model is a model that describes entities and the relationships between them. Let's create a simple EDM for the School database using Visual Studio (2012\\2015\\2017) and Entity Framework 6.", "Explicit Loading in Entity Framework", 450m, "explicit-loading-in-entity-framework", "21842bcb-fae8-4c00-9c33-de997d4e8103", 90 },
                    { 11, 2, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Language-Integrated Query (LINQ) is a powerful query language introduced in Visual Studio 2008. As the name suggests, LINQ-to-Entities queries operate on the entity set (DbSet type properties) to access the data from the underlying database. You can use the LINQ method syntax or query syntax when querying with EDM. Visit LINQ Tutorials to learn LINQ step-by-step.", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, "You can build and execute queries using Entity Framework to fetch the data from the underlying database. EF 6 supports different types of queries which in turn convert into SQL queries for the underlying database.", "Querying in Entity Core", 500m, "querying-in-entity-core", "21842bcb-fae8-4c00-9c33-de997d4e8103", 100 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentHeader", "CommentText", "PostId", "UsingIdentityUserId" },
                values: new object[,]
                {
                    { 1, "tai sao", "Sao bạn lại đăng thế", 1, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 2, "tai sao m vô lý thế", "Sao bạn lại đăng thế thế", 1, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 3, "tai sao cho điểm thấp", "Sao bạn lại đăng thế kém z", 2, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 4, "tai sao hả", "Sao bạn lại đăng thế hả", 3, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 5, "tai sao ??????", "Sao bạn lại đăng thế chứ", 3, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 6, "why", "Fuck", 3, "97571dcc-079e-4c3a-ba9b-bbde3d03a03d" },
                    { 7, "Woww", "Xinj quas", 3, "21842bcb-fae8-4c00-9c33-de997d4e8103" },
                    { 8, "!0 diem", "te qua", 3, "21842bcb-fae8-4c00-9c33-de997d4e8103" }
                });

            migrationBuilder.InsertData(
                table: "PostTagMap",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UsingIdentityUserId",
                table: "Comments",
                column: "UsingIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UsingIdentityUserId",
                table: "Posts",
                column: "UsingIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTagMap_PostId",
                table: "PostTagMap",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostTagMap");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categorys");
        }
    }
}
