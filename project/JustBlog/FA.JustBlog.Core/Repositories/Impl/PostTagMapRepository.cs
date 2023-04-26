using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Repositories.Impl
{
    public class PostTagMapRepository : IPostTagMapRepository
    {
        protected readonly JustBlogContext _context;
        public PostTagMapRepository(JustBlogContext justBlogContext = null)
        {
            this._context = justBlogContext ?? new JustBlogContext();
        }
        public IList<PostTagMap> GetByPost(int postId)
        {
            return _context.PostTagMaps.Where(x => x.PostId == postId).Include(x => x.Tag).Include(x => x.Post).ToList();
        }

        public IList<PostTagMap> GetByTag(int tagId)
        {
            return _context.PostTagMaps.Where(x => x.TagId == tagId).Include(x => x.Tag).Include(x => x.Post).ToList();
        }
    }
}
