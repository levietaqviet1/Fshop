using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Generic;

namespace FA.JustBlog.Core.Repositories
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        public void AddComment(int postId, string commentName, string commentEmail, string commentTitle, string commentBody);
        public IList<Comment> GetCommentsForPost(int postId);
        public IList<Comment> GetCommentsForPost(Post post);

    }
}
