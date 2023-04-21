using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace FA.JustBlog.UnitTest.Data
{
    public static class SeedData
    {
        public static void SeedDataTest(this JustBlogContext context)
        {
            context.IdentityRole.AddRange(GetIdentityRole());
            context.UsingIdentityUser.AddRange(GetUsingIdentityUser());
            context.IdentityUserRole.AddRange(GetIdentityUserRole());
            context.Categories.AddRange(GetCategories());
            context.Posts.AddRange(GetPosts());
            context.Tags.AddRange(GetTags());
            context.PostTagMaps.AddRange(GetPostTagMap());

            context.SaveChanges();
        }

        private static ICollection<IdentityUserRole<string>> GetIdentityUserRole()
        {
            return new List<IdentityUserRole<string>>()
            {
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
            };
        }

        private static ICollection<UsingIdentityUser> GetUsingIdentityUser()
        {
            return new List<UsingIdentityUser>() {  // toàn bộ mật khẩu Abc@123

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
                         Firstname = "Viet1",
                         LastName = "Le",
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
                      }};
        }

        private static string Uppercase(string name) { return name.ToUpper(); }
        private static ICollection<IdentityRole> GetIdentityRole()
        {
            return new List<IdentityRole>()
            {
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
            };
        }

        private static ICollection<PostTagMap> GetPostTagMap()
        {
            return new List<PostTagMap>()
            {
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
            };
        }

        private static ICollection<Tag> GetTags()
        {
            return new List<Tag>()
            {
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
            };
        }

        private static ICollection<Post> GetPosts()
        {
            return new List<Post>()
            {
                 new Post
                    {
                        Id = 1,
                        Title = "Title1",
                        ShortDescription = "ShortDescription1",
                        PostContent = "PostContent1",
                        UrlSlug = "one-to-many-conventions-entity-framework-core",
                        Published = true,
                        PostedOn = DateTime.Parse("2023-02-15"),
                        Modified = DateTime.Parse("2023-03-15"),
                        CategoryId = 1,
                        UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                    new Post
                    {
                        Id = 2,
                        Title = "Title2",
                        ShortDescription = "ShortDescription2",
                        PostContent = "PostContent2",
                        UrlSlug = "table-dataannotations-attribute-in-code-first",
                        Published = true,
                        PostedOn = DateTime.Parse("2023-03-15"),
                        Modified = DateTime.Parse("2023-03-15"),
                        CategoryId = 2,
                        UsingIdentityUserId = "97571dcc-079e-4c3a-ba9b-bbde3d03a03d"
                    },
                    new Post
                    {
                        Id = 3,
                        Title = "Title3",
                        ShortDescription = "ShortDescription3",
                        PostContent = "PostContent3",
                        UrlSlug = "demoo-abc",
                        Published = false,
                        PostedOn = DateTime.Parse("2023-03-15"),
                        Modified = DateTime.Parse("2023-03-15"),
                        CategoryId = 3,
                        UsingIdentityUserId = "21842bcb-fae8-4c00-9c33-de997d4e8103"
                    }
            };
        }

        private static ICollection<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category
                    {
                        Id = 1,
                        Name = "Entity Framework Core",
                        UrlSlug = "entity-framework-core",
                        Description = "Entity Framework Core is the new version of Entity Framework after EF 6.x. It is open-source, lightweight, extensible and a cross-platform version of Entity Framework data access technology."
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "What is Code-First",
                        UrlSlug = "what-is-code-first",
                        Description = "Entity Framework introduced the Code-First approach with Entity Framework 4.1. Code-First is mainly useful in Domain Driven Design"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Entity Framework Quiz",
                        UrlSlug = "entity-framework-quiz",
                        Description = "Test your Entity Framework knowledge. There are three quizes available in this section: Basic EF, EF 6 Code-First and EF Core quiz"
                    }
            };
        }
    }
}
