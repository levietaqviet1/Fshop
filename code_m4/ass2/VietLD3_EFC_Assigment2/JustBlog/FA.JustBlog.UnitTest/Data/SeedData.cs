using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;

namespace FA.JustBlog.UnitTest.Data
{
    public static class SeedData
    {
        public static void SeedDataTest(this JustBlogContext context)
        {
            context.Categories.AddRange(GetCategories());
            context.Posts.AddRange(GetPosts());
            context.Tags.AddRange(GetTags());
            context.PostTagMaps.AddRange(GetPostTagMap());
            context.SaveChanges();
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
                        CategoryId = 1
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
                        CategoryId = 2
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
                        CategoryId = 3
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
