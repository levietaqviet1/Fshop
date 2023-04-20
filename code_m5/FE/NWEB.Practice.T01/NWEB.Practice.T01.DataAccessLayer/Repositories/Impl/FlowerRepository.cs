using NWEB.Practice.T01.Core.DataContext;
using NWEB.Practice.T01.Core.Model;
using NWEB.Practice.T01.DataAccessLayer.Repositories;
using NWEB.Practice.T01.DataAccessLayer.Repositories.Generic;

namespace NWEB.Practice.T01.Core.Repositories.Impl
{
    public class FlowerRepository : GenericRepository<Flower>, IFlowerRepository
    {
        public FlowerRepository(FlowerShopContext flowerShopContext = null) : base(flowerShopContext)
        {
        }
    }
}
