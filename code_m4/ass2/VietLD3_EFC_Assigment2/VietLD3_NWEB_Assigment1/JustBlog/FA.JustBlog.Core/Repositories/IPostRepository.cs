using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Generic;

namespace FA.JustBlog.Core.Repositories
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        public Post FindPost(int year, int month, string urlSlug);
        public IList<Post> GetPublisedPosts();
        public IList<Post> GetUnpublisedPosts();
        public IList<Post> GetLatestPost(int size);
        public Post GetPostsByUrlSlug(string urlSlug);
        public IList<Post> GetPostsByMonth(DateTime monthYear);
        public int CountPostsForCategory(string category);
        public IList<Post> GetPostsByCategory(string category);
        public int CountPostsForTag(string tag);
        public IList<Post> GetPostsByTag(string tag);
        public IList<Post> GetMostViewedPost(int size);
        public IList<Post> GetHighestPosts(int size);
    }
}
