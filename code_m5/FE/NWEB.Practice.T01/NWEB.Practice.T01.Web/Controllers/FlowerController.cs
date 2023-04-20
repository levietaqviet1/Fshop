using Microsoft.AspNetCore.Mvc;
using NWEB.Practice.T01.Core.Model;
using NWEB.Practice.T01.DataAccessLayer.UnitOfWork;

namespace NWEB.Practice.T01.Web.Controllers
{
    public class FlowerController : Controller
    {
        // GET: CategoryController
        private IUnitOfWork _unitOfWork;

        public FlowerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IList<Flower> flowers = _unitOfWork.FlowerRepository.GetAll();
            foreach (Flower item in flowers)
            {
                item.Category = _unitOfWork.CategoryRepository.Find(item.CategoryId);
            }
            return View(flowers);
        }
    }
}
