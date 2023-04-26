using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Generic;
using FA.JustBlog.Core.Utill;

namespace FA.JustBlog.Core.Repositories.Impl
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(JustBlogContext justBlogContext = null) : base(justBlogContext)
        {
        }

        /// <summary>
        /// tìm kiếm Tag theo UrlSlug
        /// </summary>
        /// <param name="urlSlug"></param>
        /// <returns></returns>
        public Tag GetTagByUrlSlug(string urlSlug)
        {
            if (string.IsNullOrEmpty(urlSlug)) return null;

            return _context.Tags.FirstOrDefault(x => x.UrlSlug.Equals(Utils.ConFigUrlSlug(urlSlug)));
        }


    }
}
