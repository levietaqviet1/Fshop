using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Generic;
using FA.JustBlog.Core.Utill;

namespace FA.JustBlog.Core.Repositories.Impl
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(JustBlogContext justBlogContext = null) : base(justBlogContext)
        {
        }
        /// <summary>
        /// tìm kiếm Category theo UrlSlug
        /// </summary>
        /// <param name="urlSlug"></param>
        /// <returns></returns>
        public Category GetTagByUrlSlug(string urlSlug)
        {
            if (string.IsNullOrEmpty(urlSlug)) return null;

            return _context.Categories.FirstOrDefault(x => x.UrlSlug.Equals(Utils.ConFigUrlSlug(urlSlug)));
        }
    }
}
