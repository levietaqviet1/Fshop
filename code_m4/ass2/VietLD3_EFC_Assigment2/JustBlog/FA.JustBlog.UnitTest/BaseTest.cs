using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Repositories;
using FA.JustBlog.Core.Repositories.Impl;
using FA.JustBlog.UnitTest.Data;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Test
{
    public class BaseTest
    {
        protected ICategoryRepository categoryRepository;
        protected IPostRepository postRepository;
        protected ITagRepository tagRepository;

        protected JustBlogContext _context;

        public BaseTest()
        {
            DbContextOptions<JustBlogContext> dbContextOptions = new DbContextOptionsBuilder<JustBlogContext>().UseInMemoryDatabase(databaseName: "JustBlogDB").Options;

            _context = new JustBlogContext(dbContextOptions);
            _context.SeedDataTest();

            categoryRepository = new CategoryRepository(_context);
            postRepository = new PostRepository(_context);
            tagRepository = new TagRepository(_context);
        }
    }
}
