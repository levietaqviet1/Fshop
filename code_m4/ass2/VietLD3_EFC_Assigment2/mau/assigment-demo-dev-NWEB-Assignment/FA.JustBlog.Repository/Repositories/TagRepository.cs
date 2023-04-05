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
      public class TagRepository: BaseRepository<Tag>, ITagRepository
      {
            public TagRepository(JustBlogContext _context): base(_context)
            {

            }
            public Tag GetTagByUrlSlug(string urlSlug)
            {
                  return dataContext.Tags.FirstOrDefault(x=>x.UrlSlug.ToLower().Contains(urlSlug.ToLower().Trim()));
            }
      }
}
