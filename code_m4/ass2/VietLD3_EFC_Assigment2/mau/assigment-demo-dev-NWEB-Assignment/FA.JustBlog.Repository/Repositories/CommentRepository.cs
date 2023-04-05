using FA.JustBlog.Core;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Repository.Infrastructures;
using FA.JustBlog.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Repository.Repositories
{
      public class CommentRepository : BaseRepository<Comment>, ICommentRepository
      {
            public CommentRepository(JustBlogContext context) : base(context)
            {
            }

            public void AddComment(int postId, string commentName, string commentEmail, string commentTitle, string commentBody)
            {
                  var maxId = dataContext.Comments.Max(x => x.Id);
                  Comment comment = new Comment();
                  comment.Id = maxId + 1;
                  comment.Name = commentName;
                  comment.CommentTime = DateTime.Now;
                  comment.CommentText = commentBody;
                  comment.CommentHeader = commentTitle;
                  comment.Email = commentEmail;
                  comment.PostId = postId;

                  dataContext.Comments.Add(comment);
                  dataContext.SaveChanges();
            }

            public IList<Comment> GetCommentsForPost(int postId)
            {
                  return dataContext.Comments.Join(dataContext.Posts, x => x.PostId, y => y.Id, (x, y) => new
                  {
                        Comment = x,
                        Post = y
                  }).Where(x => x.Post.Id == postId).Select(x => x.Comment).ToList();
            }

            public IList<Comment> GetCommentsForPost(Post post)
            {
                  return dataContext.Comments.Join(dataContext.Posts, x => x.PostId, y => y.Id, (x, y) => new
                  {
                        Comment = x,
                        Post = y
                  }).Where(x => x.Post.Id == post.Id).Select(x => x.Comment).ToList();
            }
      }
}
