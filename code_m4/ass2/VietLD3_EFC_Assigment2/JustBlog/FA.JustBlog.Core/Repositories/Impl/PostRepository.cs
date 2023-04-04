using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Generic;
using FA.JustBlog.Core.Utill;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Repositories.Impl
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(JustBlogContext justBlogContext = null) : base(justBlogContext)
        {

        }

        /// <summary>
        /// lấy ra tổng số post theo Category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public int CountPostsForCategory(string category)
        {
            return _context.Posts.Include(x => x.Category).Where(x => x.Category.Name.ToLower().Equals(category.ToLower())).Count();
        }

        /// <summary>
        /// lấy ra tổng số post theo tag
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public int CountPostsForTag(string tag)
        {
            return _context.PostTagMaps.Include(x => x.Post).Include(x => x.Tag).Where(x => x.Tag.Name.ToLower().Equals(tag.ToLower())).Count();
        }

        /// <summary>
        /// tìm post theo năm và tháng và urlSlug
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="urlSlug"></param>
        /// <returns></returns>
        public Post FindPost(int year, int month, string urlSlug)
        {

            return _context.Posts.FirstOrDefault(x => x.PostedOn.Year == year && x.PostedOn.Month == month && x.UrlSlug.Equals(Utils.ConFigUrlSlug(urlSlug)));
        }

        /// <summary>
        /// lấy ra danh sách post theo tứ tự giảm dần của thời gian đăng và lấy ra size cái 
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public IList<Post> GetLatestPost(int size)
        {
            return _context.Posts.OrderByDescending(z => z.PostedOn).Take(size).ToList();
        }

        /// <summary>
        /// lấy ra danh sách Post có lượng view sắp xếp giảm dần và lấy ra size danh sách
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public IList<Post> GetHighestPosts(int size)
        {
            return _context.Posts.OrderByDescending(x => x.ViewCount).Take(size).ToList();
        }

        /// <summary>
        /// lấy ra danh sách Post có lượng view sắp xếp tăng dần và lấy ra size danh sách
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public IList<Post> GetMostViewedPost(int size)
        {
            return _context.Posts.OrderBy(x => x.ViewCount).Take(size).ToList();
        }

        /// <summary>
        /// lấy ra danh sách post theo category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public IList<Post> GetPostsByCategory(string category)
        {
            return _context.Posts.Include(x => x.Category).Where(x => x.Category.Name.ToLower().Equals(category.ToLower())).ToArray();
        }

        /// <summary>
        /// lấy ra danh sách post theo tháng
        /// </summary>
        /// <param name="monthYear"></param>
        /// <returns></returns>
        public IList<Post> GetPostsByMonth(DateTime monthYear)
        {
            int year = monthYear.Year;
            int month = monthYear.Month;

            return _context.Posts.Where(p => p.PostedOn.Year == year && p.PostedOn.Month == month).ToList();
        }

        /// <summary>
        /// lấy ra danh sách post theo tag name
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public IList<Post> GetPostsByTag(string tag)
        {
            return _context.Posts.Include(x => x.PostTagMaps).Where(x => x.PostTagMaps.Any(ptm => ptm.Tag.Name.ToLower().Equals(tag.ToLower())))
                   .ToList();
        }

        /// <summary>
        /// lấy ra danh sách post để công khai
        /// </summary>
        /// <returns></returns>
        public IList<Post> GetPublisedPosts()
        {
            return _context.Posts.Where(x => x.Published).ToList();
        }

        /// <summary>
        /// lấy ra danh sách post để không công khai
        /// </summary>
        /// <returns></returns>
        public IList<Post> GetUnpublisedPosts()
        {
            return _context.Posts.Where(x => !x.Published).ToList();
        }
    }
}
