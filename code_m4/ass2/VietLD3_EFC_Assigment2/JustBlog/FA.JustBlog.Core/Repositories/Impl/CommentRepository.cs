using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Generic;

namespace FA.JustBlog.Core.Repositories.Impl
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(JustBlogContext justBlogContext = null) : base(justBlogContext)
        {
        }

        /// <summary>
        /// thêm mới 1 comment vào trong danh sách
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="commentName"></param>
        /// <param name="commentEmail"></param>
        /// <param name="commentTitle"></param>
        /// <param name="commentBody"></param>
        public void AddComment(int postId, string commentTitle, string commentBody, int userId)
        {
            Add(new Comment(commentTitle, commentBody, postId, userId));
        }

        /// <summary>
        /// lấy ra tất cả các comment theo id post
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public IList<Comment> GetCommentsForPost(int postId)
        {
            return _context.Comments.Where(x => x.PostId == postId).ToArray();
        }

        /// <summary>
        /// lấy ra danh sách comment theo Post
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public IList<Comment> GetCommentsForPost(Post post)
        {
            return _context.Comments.Where(x => x.PostId == post.Id).ToArray();
        }
    }
}
