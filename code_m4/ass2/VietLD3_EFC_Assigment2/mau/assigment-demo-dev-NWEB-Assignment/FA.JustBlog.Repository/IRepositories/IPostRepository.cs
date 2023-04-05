using FA.JustBlog.Core.Models;
using FA.JustBlog.Repository.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Repository.IRepositories
{
      public interface IPostRepository:IBaseRepository<Post>
      {
            /// <summary>
            /// Get Post from Database by year, month and UrlSlug
            /// </summary>
            /// <param name="year"></param>
            /// <param name="month"></param>
            /// <param name="urlSlug"></param>
            /// <returns></returns>
            Post FindPost(int year, int month, string urlSlug);

            /// <summary>
            /// Get all Posts from Database had published
            /// </summary>
            /// <returns></returns>
           IList<Post> GetPublisedPosts();

            /// <summary>
            /// Get all Posts from Database had not published
            /// </summary>
            /// <returns></returns>
           IList<Post> GetUnpublisedPosts();

            /// <summary>
            /// Get all Posts from Database that is posted on lastest time with size
            /// </summary>
            /// <param name="size"></param>
            /// <returns></returns>
           IList<Post> GetLatestPost(int size);

            /// <summary>
            /// Get all Posts from Database by month
            /// </summary>
            /// <param name="monthYear"></param>
            /// <returns></returns>
           IList<Post> GetPostsByMonth(DateTime monthYear);

            /// <summary>
            /// Get number of Posts by CategeoryName
            /// </summary>
            /// <param name="category"></param>
            /// <returns></returns>
           int CountPostsForCategory(string category);

            /// <summary>
            /// Get all Posts from Database by CategoryName
            /// </summary>
            /// <param name="category"></param>
            /// <returns></returns>
           IList<Post> GetPostsByCategory(string category);
            
            /// <summary>
            /// Get number of Posts from Database by TagName
            /// </summary>
            /// <param name="tag"></param>
            /// <returns></returns>
            int CountPostsForTag(string tag);

            /// <summary>
            /// Get all Posts from Database by TagName
            /// </summary>
            /// <param name="tag"></param>
            /// <returns></returns>
            IList<Post> GetPostsByTag(string tag);

            /// <summary>
            /// Get all Posts that are most vied
            /// </summary>
            /// <param name="size"></param>
            /// <returns></returns>
            IList<Post> GetMostViewedPost(int size);
            
            /// <summary>
            /// Get all Posts that is highest
            /// </summary>
            /// <param name="size"></param>
            /// <returns></returns>
            IList<Post> GetHighestPosts(int size);
      }
}
