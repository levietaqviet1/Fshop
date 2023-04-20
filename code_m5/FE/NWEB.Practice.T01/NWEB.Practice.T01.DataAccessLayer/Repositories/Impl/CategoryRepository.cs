using NWEB.Practice.T01.Core.DataContext;
using NWEB.Practice.T01.Core.Model;
using NWEB.Practice.T01.DataAccessLayer.Repositories.Generic;

namespace NWEB.Practice.T01.DataAccessLayer.Repositories.Impl
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(FlowerShopContext flowerShopContext = null) : base(flowerShopContext)
        {
        }
    }
}
