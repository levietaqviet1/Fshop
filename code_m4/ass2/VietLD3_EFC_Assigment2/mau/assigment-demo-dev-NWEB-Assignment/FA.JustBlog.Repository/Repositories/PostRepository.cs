using FA.JustBlog.Repository.Infrastructures;
using FA.JustBlog.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core;

namespace FA.JustBlog.Repository.Repositories
{
      public class PostRepository : BaseRepository<Post>, IPostRepository
      {
            public PostRepository(JustBlogContext dataContext): base(dataContext)
            {
            }

            public int CountPostsForCategory(string category)
            {
                  /*var result = from post in dataContext.Posts
                                join catgory in dataContext.Categories on post.CategoryId equals catgory.Id
                                where catgory.Name == category
                                group post.Id by catgory.Id into g
                                select g.Count();
                  return result.FirstOrDefault();*/
                  return dataContext.Posts.Join(dataContext.Categories, x => x.CategoryId, y => y.Id, (x, y) => new
                  {
                        y.Name
                  }).Where(x => x.Name == category).Count();
            }

            public int CountPostsForTag(string tag)
            {
                  return dataContext.PostTagMaps.Join(dataContext.Tags, x => x.TagId, y => y.Id, (x, y) => new
                  {
                        x.PostId,
                        y.Id,
                        y.Name
                  }).Where(x => x.Name == tag).Count();
                  //return dataContext.Posts.Count(x => x.PostTagMaps.Any(t => t.Tag.Name.Equals(tag)));
            }

            public Post FindPost(int year, int month, string urlSlug)
            {
                  return dataContext.Posts.FirstOrDefault(x => x.PostedOn.Year == year && x.PostedOn.Month == month && x.UrlSlug.ToLower().Contains(urlSlug.ToLower().Trim()));
            }

            public IList<Post> GetHighestPosts(int size)
            {
                  var posts = dbSet.Select(x => new Post()).ToList();
                  return posts.OrderByDescending(x => x.Rate).Take(size).ToList();
            }

            public IList<Post> GetLatestPost(int size)
            {
                  return dataContext.Posts.OrderByDescending(x => x.PostedOn).Take(size).ToList();
            }

            public IList<Post> GetMostViewedPost(int size)
            {
                  return dataContext.Posts.OrderByDescending(x => x.ViewCount).Take(size).ToList();
            }

            public IList<Post> GetPostsByCategory(string category)
            {
                  /*var result = from p in dataContext.Posts
                                    join c in dataContext.Categories on p.CategoryId equals c.Id
                                    where c.Name == category
                                    select p;
                  return result.ToList();*/
                  return dataContext.Posts.Join(dataContext.Categories, x => x.CategoryId, y => y.Id, (x, y) => new
                  {
                        Post = x,
                        Category = y
                  }).Where(y => y.Category.Name == category).Select(x => x.Post).ToList();
            }

            public IList<Post> GetPostsByMonth(DateTime monthYear)
            {
                  return dataContext.Posts.Where(x => x.PostedOn.Month == monthYear.Month).ToList();
            }

            public IList<Post> GetPostsByTag(string tag)
            {
                  return dataContext.PostTagMaps.Join(dataContext.Posts, x => x.PostId, y => y.Id, (x, y) => new
                  {
                        PostTagMap = x,
                        Post = y,
                  }).Join(dataContext.Tags, x => x.PostTagMap.TagId, y => y.Id, (x, y) => new
                  {
                        Post = x.Post,
                        Tag = y,
                  }).Where(x => x.Tag.Name.ToLower().Contains(tag.ToLower().Trim())).Select(x=>x.Post).ToList();
            }

            public IList<Post> GetPublisedPosts()
            {
                  return dataContext.Posts.Where(x => x.Published == true).ToList();
            }

            public IList<Post> GetUnpublisedPosts()
            {
                  return dataContext.Posts.Where(x => x.Published == false).ToList();
            }
      }
}
