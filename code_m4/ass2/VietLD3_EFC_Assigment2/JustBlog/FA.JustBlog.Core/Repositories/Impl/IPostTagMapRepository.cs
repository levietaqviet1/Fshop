using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Repositories.Impl
{
    public interface IPostTagMapRepository
    {
        public IList<PostTagMap> GetByPost(int postId);
        public IList<PostTagMap> GetByTag(int tagId);
    }
}
