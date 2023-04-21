using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Generic;

namespace FA.JustBlog.Core.Repositories
{
    public interface ITagRepository : IGenericRepository<Tag>
    {
        Tag GetTagByUrlSlug(string urlSlug);
    }
}
