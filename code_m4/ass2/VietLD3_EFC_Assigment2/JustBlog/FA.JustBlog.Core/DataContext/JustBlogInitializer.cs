using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Utill;
using Microsoft.AspNetCore.Identity;

namespace FA.JustBlog.Core.DataContext
{
    public static class JustBlogInitializer
    {

        private static string Uppercase(string name) { return name.ToUpper(); }
        public static void SeedData(this Microsoft.EntityFrameworkCore.ModelBuilder builder)
        {
            // thêm dữ liệu
            builder.Entity<IdentityRole>().HasData
                (
                    new IdentityRole
                    {
                        Id = "db5782c7-bf14-41f7-bc1f-950128ecb3bb",
                        Name = "Blog Owner",
                        NormalizedName = Uppercase("Blog Owner"),
                        ConcurrencyStamp = "b31bbed6-4919-4f52-a4b1-c45091a8fbf0"
                    },
                     new IdentityRole
                     {
                         Id = "e94a9bca-5a7a-4806-b8cd-97e9075ff13a",
                         Name = "Contributor",
                         NormalizedName = Uppercase("Contributor"),
                         ConcurrencyStamp = "e22ebaa4-db51-4cb3-8f37-ad4ba73b0e1e"
                     }
                );

            builder.Entity<UsingIdentityUser>().HasData
                (
                    // toàn bộ mật khẩu Abc@123

                    new UsingIdentityUser
                    {
                        Id = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d",
                        Firstname = "Viet",
                        LastName = "Le",
                        UserName = "vietContributor@gmail.com",
                        NormalizedUserName = Uppercase("vietContributor@gmail.com"),
                        Email = "vietContributor@gmail.com",
                        NormalizedEmail = Uppercase("vietContributor@gmail.com"),
                        EmailConfirmed = true,
                        PasswordHash = "AQAAAAEAACcQAAAAEJ51SmQrANatorjKkODvG7wRz8i73uIAUIHAmXRldg8ikayfZiaDQvbSOuY+XFPiJQ==",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = false,
                        LockoutEnabled = false,
                        AccessFailedCount = 0,
                        PhoneNumber = "0985695635",

                    },
                     new UsingIdentityUser
                     {
                         Id = "21842bcb-fae8-4c00-9c33-de997d4e8103",
                         Firstname = "Khi",
                         LastName = "nguyen",
                         UserName = "vietBlogOwner@gmail.com",
                         NormalizedUserName = Uppercase("vietBlogOwner@gmail.com"),
                         Email = "vietBlogOwner@gmail.com",
                         NormalizedEmail = Uppercase("vietBlogOwner@gmail.com"),
                         EmailConfirmed = true,
                         PasswordHash = "AQAAAAEAACcQAAAAEGf8AICmlUDtMuw9p1TPGYB0/OH8X60Ud06sUakpWa+Tpu2IJAZvF6Ht7DxsYeWEjA==",
                         PhoneNumberConfirmed = true,
                         TwoFactorEnabled = false,
                         LockoutEnabled = false,
                         AccessFailedCount = 0,
                         PhoneNumber = "045896589",
                     },
                      new UsingIdentityUser
                      {
                          Id = "b0446349-235d-4b0f-a8e9-87382a82923f",
                          Firstname = "Toan",
                          LastName = "Nguyen",
                          UserName = "user@gmail.com",
                          NormalizedUserName = Uppercase("user@gmail.com"),
                          Email = "user@gmail.com",
                          NormalizedEmail = Uppercase("user@gmail.com"),
                          EmailConfirmed = true,
                          PasswordHash = "AQAAAAEAACcQAAAAED7S01cmZYmeJEKd7/wVP+HGOCSHbR/Xl2NRWyWTXB6JbwfXREcO2D908cRKtFG2Ag==",
                          PhoneNumberConfirmed = true,
                          TwoFactorEnabled = false,
                          LockoutEnabled = false,
                          AccessFailedCount = 0,
                          PhoneNumber = "0458796598",
                      }
                );

            builder.Entity<IdentityUserRole<string>>().HasData
                (
                    new IdentityUserRole<string>
                    {
                        RoleId = "db5782c7-bf14-41f7-bc1f-950128ecb3bb",
                        UserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "e94a9bca-5a7a-4806-b8cd-97e9075ff13a",
                        UserId = "21842bcb-fae8-4c00-9c33-de997d4e8103"
                    }
                );


            builder.Entity<Category>().HasData
                (
                    new Category
                    {
                        Id = 1,
                        Name = "EF Basics",
                        UrlSlug = Utils.ConFigUrlSlug("EF Basics"),
                        Description = "If you're completely new to Entity Framework, we recommend you to learn Entity Framework basics first and gradually move forward."
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "EF 6 DB-First",
                        UrlSlug = Utils.ConFigUrlSlug("EF 6 DB-First"),
                        Description = "If you want to use or currently Entity Framework 6.x with existing database then learn Entity Framework 6 Database-First Approach in this section."
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "EF 6 Code-First",
                        UrlSlug = Utils.ConFigUrlSlug("EF 6 Code-First"),
                        Description = "If you are using DDD (Domain Driven Design) for your application then learn Entity Framework 6 Code-First Approach in this section."
                    }
                );
            builder.Entity<Post>().HasData
                (
                    new Post
                    {
                        Id = 1,
                        Title = "What is Entity Framework?",
                        ShortDescription = " to save or retrieve application data from the underlying database. We used to open a connection to the database, create a DataSet to fetch or submit the data to the database, convert data from the DataSet to .NET objects or vice-versa to apply business rules. This was a cumbersome and error prone process.",
                        PostContent = "Entity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is stored. With the Entity Framework, developers can work at a higher level of abstraction when they deal with data.",
                        UrlSlug = Utils.ConFigUrlSlug("What is Entity Framework?"),
                        Published = true,
                        PostedOn = DateTime.Parse("2023-02-15"),
                        Modified = DateTime.Parse("2023-03-15"),
                        CategoryId = 1,
                        UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                    new Post
                    {
                        Id = 2,
                        Title = "Basic Workflow in Entity Framework",
                        ShortDescription = "First of all, you need to define your model. Defining the model includes defining your domain classes, context class derived from DbContext, and configurations (if any). EF will perform CRUD operations based on your model.",
                        PostContent = "Let's understand the above EF workflow: To insert data, add a domain object to a context and call the SaveChanges() method. EF API will build an appropriate INSERT command and execute it to the database.  To read data, execute the LINQ-to-Entities query in your preferred language (C#/VB.NET). EF API will convert this query into SQL query for the underlying relational database and execute it.",
                        UrlSlug = Utils.ConFigUrlSlug("Basic Workflow in Entity Framework"),
                        Published = true,
                        PostedOn = DateTime.Parse("2023-02-14"),
                        Modified = DateTime.Parse("2023-03-15"),
                        CategoryId = 1,
                        UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                    new Post
                    {
                        Id = 3,
                        Title = "Entity Framework 6 Introduction",
                        ShortDescription = "Welcome to Entity Framework 6 database-first tutorials section. Here, you will learn how to use Entity Framework 6 with the existing database of your application. It starts from creating an Entity Data Model from your existing database and it will show you how to save and query data using Entity Framework 6.x.",
                        PostContent = "EF 6 Database-First and Code-First Features Creating Entity Data Model from your existing database Querying data using LINQ Saving data Using existing stored procedures, views, and table-valued functions CRUD operations using stored procedures  Optimistic concurrency & transactions support Supports Spatial Data Types Connection resiliency  Asynchronous query and save  Code-based configuration  Database command logging  Database command interception  ",
                        UrlSlug = Utils.ConFigUrlSlug("Entity Framework 6 Introduction"),
                        Published = true,
                        PostedOn = DateTime.Parse("2023-03-15"),
                        Modified = DateTime.Parse("2023-03-15"),
                        CategoryId = 2,
                        UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                    new Post
                    {
                        Id = 4,
                        Title = "Creating an Entity Data Model",
                        ShortDescription = "Here, we are going to create an Entity Data Model (EDM) for an existing database in database-first approach and understand the basic building blocks.    Entity Framework uses EDM for all the database-related operations. Entity Data Model is a model that describes entities and the relationships between them. Let's create a simple EDM for the School database using Visual Studio (2012\\2015\\2017) and Entity Framework 6.",
                        PostContent = "Here, we are going to create an Entity Data Model (EDM) for an existing database in database-first approach and understand the basic building blocks.    Entity Framework uses EDM for all the database-related operations. Entity Data Model is a model that describes entities and the relationships between them. Let's create a simple EDM for the School database using Visual Studio (2012\\2015\\2017) and Entity Framework 6.",
                        UrlSlug = Utils.ConFigUrlSlug("Creating an Entity Data Model"),
                        Published = false,
                        PostedOn = DateTime.Parse("2023-03-15"),
                        Modified = DateTime.Parse("2023-03-15"),
                        CategoryId = 2,
                        UsingIdentityUserId = "21842bcb-fae8-4c00-9c33-de997d4e8103"
                    }
            );
            builder.Entity<Tag>().HasData
                (
                    new Tag
                    {
                        Id = 1,
                        Name = "Querying in Entity Framework Core",
                        UrlSlug = "querying-in-ef-core",
                        Description = "Querying in Entity Framework Core remains the same as in EF 6.x, with more optimized SQL queries and the ability to include C#/VB.NET functions into LINQ-to-Entities queries",
                        Count = 1
                    },
                    new Tag
                    {
                        Id = 2,
                        Name = "Entity Framework Core: Saving Data in Connected Scenario",
                        UrlSlug = "saving-data-in-connected-scenario-in-ef-core",
                        Description = "Entity Framework Core provides different ways to add, update, or delete data in the underlying database",
                        Count = 2
                    },
                    new Tag
                    {
                        Id = 3,
                        Name = "Conventions in Entity Framework Core",
                        UrlSlug = "conventions-in-ef-core",
                        Description = "Conventions are default rules using which Entity Framework builds a model based on your domain (entity) classes",
                        Count = 3
                    }
                );
            builder.Entity<PostTagMap>().HasData
                (
                    new PostTagMap
                    {
                        PostId = 1,
                        TagId = 2,
                    },
                    new PostTagMap
                    {
                        PostId = 1,
                        TagId = 1,
                    },
                    new PostTagMap
                    {
                        PostId = 1,
                        TagId = 3,
                    }
            );

            builder.Entity<Comment>().HasData
                (
                    new Comment
                    {
                        Id = 1,
                        CommentHeader = "tai sao",
                        CommentText = "Sao bạn lại đăng thế",
                        PostId = 1,
                        UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                    new Comment
                    {
                        Id = 2,
                        CommentHeader = "tai sao m vô lý thế",
                        CommentText = "Sao bạn lại đăng thế thế",
                        PostId = 1,
                        UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                     new Comment
                     {
                         Id = 3,
                         CommentHeader = "tai sao cho điểm thấp",
                         CommentText = "Sao bạn lại đăng thế kém z",
                         PostId = 2,
                         UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                     },
                    new Comment
                    {
                        Id = 4,
                        CommentHeader = "tai sao hả",
                        CommentText = "Sao bạn lại đăng thế hả",
                        PostId = 3,
                        UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                    new Comment
                    {
                        Id = 5,
                        CommentHeader = "tai sao ??????",
                        CommentText = "Sao bạn lại đăng thế chứ",
                        PostId = 3,
                        UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                    new Comment
                    {
                        Id = 6,
                        CommentHeader = "why",
                        CommentText = "Fuck",
                        PostId = 3,
                        UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                     new Comment
                     {
                         Id = 7,
                         CommentHeader = "Woww",
                         CommentText = "Xinj quas",
                         PostId = 3,
                         UsingIdentityUserId = "21842bcb-fae8-4c00-9c33-de997d4e8103"
                     },
                    new Comment
                    {
                        Id = 8,
                        CommentHeader = "!0 diem",
                        CommentText = "te qua",
                        PostId = 3,
                        UsingIdentityUserId = "21842bcb-fae8-4c00-9c33-de997d4e8103"
                    }
                );
        }
    }
}
