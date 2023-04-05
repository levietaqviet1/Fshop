using FA.JustBlog.Core.Models;
using FA.JustBlog.Repository.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Repository.IRepositories
{
      public interface ICommentRepository : IBaseRepository<Comment>
      {
            /// <summary>
            /// Add Comment by specific fields to Database
            /// </summary>
            /// <param name="postId"></param>
            /// <param name="commentName"></param>
            /// <param name="commentEmail"></param>
            /// <param name="commentTitle"></param>
            /// <param name="commentBody"></param>
            void AddComment(int postId, string commentName, string commentEmail, string commentTitle,
            string commentBody);

            /// <summary>
            /// Get all Comments from Database by PostId
            /// </summary>
            /// <param name="postId"></param>
            /// <returns></returns>
            IList<Comment> GetCommentsForPost(int postId);

            /// <summary>
            /// Get all Comments from Database by Post
            /// </summary>
            /// <param name="post"></param>
            /// <returns></returns>
            IList<Comment> GetCommentsForPost(Post post);
      }
}
