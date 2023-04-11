﻿// <auto-generated />
using System;
using FA.JustBlog.Core.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    [DbContext(typeof(JustBlogContext))]
    [Migration("20230411100830_v21")]
    partial class v21
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FA.JustBlog.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Categorys", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "If you're completely new to Entity Framework, we recommend you to learn Entity Framework basics first and gradually move forward.",
                            Name = "EF Basics",
                            UrlSlug = "ef-basics"
                        },
                        new
                        {
                            Id = 2,
                            Description = "If you want to use or currently Entity Framework 6.x with existing database then learn Entity Framework 6 Database-First Approach in this section.",
                            Name = "EF 6 DB-First",
                            UrlSlug = "ef-6-db-first"
                        },
                        new
                        {
                            Id = 3,
                            Description = "If you are using DDD (Domain Driven Design) for your application then learn Entity Framework 6 Code-First Approach in this section.",
                            Name = "EF 6 Code-First",
                            UrlSlug = "ef-6-code-first"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CommentHeader")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CommentTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 4, 11, 17, 8, 30, 180, DateTimeKind.Local).AddTicks(6779));

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("UsingIdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UsingIdentityUserId");

                    b.ToTable("Comments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CommentHeader = "tai sao",
                            CommentText = "Sao bạn lại đăng thế",
                            CommentTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostId = 1,
                            UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                        },
                        new
                        {
                            Id = 2,
                            CommentHeader = "tai sao m vô lý thế",
                            CommentText = "Sao bạn lại đăng thế thế",
                            CommentTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostId = 1,
                            UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                        },
                        new
                        {
                            Id = 3,
                            CommentHeader = "tai sao cho điểm thấp",
                            CommentText = "Sao bạn lại đăng thế kém z",
                            CommentTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostId = 2,
                            UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                        },
                        new
                        {
                            Id = 4,
                            CommentHeader = "tai sao hả",
                            CommentText = "Sao bạn lại đăng thế hả",
                            CommentTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostId = 3,
                            UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                        },
                        new
                        {
                            Id = 5,
                            CommentHeader = "tai sao ??????",
                            CommentText = "Sao bạn lại đăng thế chứ",
                            CommentTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostId = 3,
                            UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                        },
                        new
                        {
                            Id = 6,
                            CommentHeader = "why",
                            CommentText = "Fuck",
                            CommentTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostId = 3,
                            UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                        },
                        new
                        {
                            Id = 7,
                            CommentHeader = "Woww",
                            CommentText = "Xinj quas",
                            CommentTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostId = 3,
                            UsingIdentityUserId = "21842bcb-fae8-4c00-9c33-de997d4e8103"
                        },
                        new
                        {
                            Id = 8,
                            CommentHeader = "!0 diem",
                            CommentText = "te qua",
                            CommentTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostId = 3,
                            UsingIdentityUserId = "21842bcb-fae8-4c00-9c33-de997d4e8103"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostContent")
                        .IsRequired()
                        .HasMaxLength(500000000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Published")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<decimal>("Rate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("RateCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalRate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsingIdentityUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ViewCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UsingIdentityUserId");

                    b.ToTable("Posts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Modified = new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostContent = "Entity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is stored. With the Entity Framework, developers can work at a higher level of abstraction when they deal with data.",
                            PostedOn = new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            Rate = 0m,
                            RateCount = 10m,
                            ShortDescription = " to save or retrieve application data from the underlying database. We used to open a connection to the database, create a DataSet to fetch or submit the data to the database, convert data from the DataSet to .NET objects or vice-versa to apply business rules. This was a cumbersome and error prone process.",
                            Title = "What is Entity Framework?",
                            TotalRate = 25m,
                            UrlSlug = "what-is-entity-framework",
                            UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                            ViewCount = 5
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Modified = new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostContent = "Let's understand the above EF workflow: To insert data, add a domain object to a context and call the SaveChanges() method. EF API will build an appropriate INSERT command and execute it to the database.  To read data, execute the LINQ-to-Entities query in your preferred language (C#/VB.NET). EF API will convert this query into SQL query for the underlying relational database and execute it.",
                            PostedOn = new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            Rate = 0m,
                            RateCount = 200m,
                            ShortDescription = "First of all, you need to define your model. Defining the model includes defining your domain classes, context class derived from DbContext, and configurations (if any). EF will perform CRUD operations based on your model.",
                            Title = "Basic Workflow in Entity Framework",
                            TotalRate = 250m,
                            UrlSlug = "basic-workflow-in-entity-framework",
                            UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                            ViewCount = 50
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Modified = new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostContent = "EF 6 Database-First and Code-First Features Creating Entity Data Model from your existing database Querying data using LINQ Saving data Using existing stored procedures, views, and table-valued functions CRUD operations using stored procedures  Optimistic concurrency & transactions support Supports Spatial Data Types Connection resiliency  Asynchronous query and save  Code-based configuration  Database command logging  Database command interception  ",
                            PostedOn = new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            Rate = 0m,
                            RateCount = 200m,
                            ShortDescription = "Welcome to Entity Framework 6 database-first tutorials section. Here, you will learn how to use Entity Framework 6 with the existing database of your application. It starts from creating an Entity Data Model from your existing database and it will show you how to save and query data using Entity Framework 6.x.",
                            Title = "Entity Framework 6 Introduction",
                            TotalRate = 300m,
                            UrlSlug = "entity-framework-6-introduction",
                            UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                            ViewCount = 60
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Modified = new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostContent = "Here, we are going to create an Entity Data Model (EDM) for an existing database in database-first approach and understand the basic building blocks.    Entity Framework uses EDM for all the database-related operations. Entity Data Model is a model that describes entities and the relationships between them. Let's create a simple EDM for the School database using Visual Studio (2012\\2015\\2017) and Entity Framework 6.",
                            PostedOn = new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = false,
                            Rate = 0m,
                            RateCount = 300m,
                            ShortDescription = "Here, we are going to create an Entity Data Model (EDM) for an existing database in database-first approach and understand the basic building blocks.    Entity Framework uses EDM for all the database-related operations. Entity Data Model is a model that describes entities and the relationships between them. Let's create a simple EDM for the School database using Visual Studio (2012\\2015\\2017) and Entity Framework 6.",
                            Title = "Creating an Entity Data Model",
                            TotalRate = 450m,
                            UrlSlug = "creating-an-entity-data-model",
                            UsingIdentityUserId = "21842bcb-fae8-4c00-9c33-de997d4e8103",
                            ViewCount = 90
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTagMap", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("TagId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("PostTagMap", (string)null);

                    b.HasData(
                        new
                        {
                            TagId = 2,
                            PostId = 1
                        },
                        new
                        {
                            TagId = 1,
                            PostId = 1
                        },
                        new
                        {
                            TagId = 3,
                            PostId = 1
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Tags", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 1,
                            Description = "Querying in Entity Framework Core remains the same as in EF 6.x, with more optimized SQL queries and the ability to include C#/VB.NET functions into LINQ-to-Entities queries",
                            Name = "Querying in Entity Framework Core",
                            UrlSlug = "querying-in-ef-core"
                        },
                        new
                        {
                            Id = 2,
                            Count = 2,
                            Description = "Entity Framework Core provides different ways to add, update, or delete data in the underlying database",
                            Name = "Entity Framework Core: Saving Data in Connected Scenario",
                            UrlSlug = "saving-data-in-connected-scenario-in-ef-core"
                        },
                        new
                        {
                            Id = 3,
                            Count = 3,
                            Description = "Conventions are default rules using which Entity Framework builds a model based on your domain (entity) classes",
                            Name = "Conventions in Entity Framework Core",
                            UrlSlug = "conventions-in-ef-core"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.UsingIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "26fde9db-076a-4796-b14a-a87a128ec02c",
                            Email = "vietContributor@gmail.com",
                            EmailConfirmed = true,
                            Firstname = "Viet",
                            LastName = "Le",
                            LockoutEnabled = false,
                            NormalizedEmail = "VIETCONTRIBUTOR@GMAIL.COM",
                            NormalizedUserName = "VIETCONTRIBUTOR@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ51SmQrANatorjKkODvG7wRz8i73uIAUIHAmXRldg8ikayfZiaDQvbSOuY+XFPiJQ==",
                            PhoneNumber = "0985695635",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "b080092c-0992-4270-a605-1cabafcc0e62",
                            TwoFactorEnabled = false,
                            UserName = "vietContributor@gmail.com"
                        },
                        new
                        {
                            Id = "21842bcb-fae8-4c00-9c33-de997d4e8103",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1ea66bac-2680-4e12-b57b-b51de8e9bec1",
                            Email = "vietBlogOwner@gmail.com",
                            EmailConfirmed = true,
                            Firstname = "Khi",
                            LastName = "nguyen",
                            LockoutEnabled = false,
                            NormalizedEmail = "VIETBLOGOWNER@GMAIL.COM",
                            NormalizedUserName = "VIETBLOGOWNER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGf8AICmlUDtMuw9p1TPGYB0/OH8X60Ud06sUakpWa+Tpu2IJAZvF6Ht7DxsYeWEjA==",
                            PhoneNumber = "045896589",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "27f7ebb7-61ae-4cba-9cf2-4ad90e79a5f0",
                            TwoFactorEnabled = false,
                            UserName = "vietBlogOwner@gmail.com"
                        },
                        new
                        {
                            Id = "b0446349-235d-4b0f-a8e9-87382a82923f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ded7b419-a8a6-48d3-b16e-d1bb547a2bbd",
                            Email = "user@gmail.com",
                            EmailConfirmed = true,
                            Firstname = "Toan",
                            LastName = "Nguyen",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@GMAIL.COM",
                            NormalizedUserName = "USER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAED7S01cmZYmeJEKd7/wVP+HGOCSHbR/Xl2NRWyWTXB6JbwfXREcO2D908cRKtFG2Ag==",
                            PhoneNumber = "0458796598",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "16d1ea2f-d078-489c-8ef5-0b5299428d78",
                            TwoFactorEnabled = false,
                            UserName = "user@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "db5782c7-bf14-41f7-bc1f-950128ecb3bb",
                            ConcurrencyStamp = "b31bbed6-4919-4f52-a4b1-c45091a8fbf0",
                            Name = "Blog Owner",
                            NormalizedName = "BLOG OWNER"
                        },
                        new
                        {
                            Id = "e94a9bca-5a7a-4806-b8cd-97e9075ff13a",
                            ConcurrencyStamp = "e22ebaa4-db51-4cb3-8f37-ad4ba73b0e1e",
                            Name = "Contributor",
                            NormalizedName = "CONTRIBUTOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                            RoleId = "db5782c7-bf14-41f7-bc1f-950128ecb3bb"
                        },
                        new
                        {
                            UserId = "21842bcb-fae8-4c00-9c33-de997d4e8103",
                            RoleId = "e94a9bca-5a7a-4806-b8cd-97e9075ff13a"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Comment", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.JustBlog.Core.Models.UsingIdentityUser", null)
                        .WithMany("Comments")
                        .HasForeignKey("UsingIdentityUserId");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.JustBlog.Core.Models.UsingIdentityUser", null)
                        .WithMany("Posts")
                        .HasForeignKey("UsingIdentityUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTagMap", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Post", "Post")
                        .WithMany("PostTagMaps")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.JustBlog.Core.Models.Tag", "Tag")
                        .WithMany("PostTagMaps")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.UsingIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.UsingIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.JustBlog.Core.Models.UsingIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.UsingIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("PostTagMaps");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tag", b =>
                {
                    b.Navigation("PostTagMaps");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.UsingIdentityUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
