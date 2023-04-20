using Microsoft.AspNetCore.Mvc;
using NWEB.Practice.T01.Core.Model;
using NWEB.Practice.T01.DataAccessLayer.UnitOfWork;

namespace NWEB.Practice.T01.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SaleOffController : Controller
    {
        // GET: CategoryController
        private IUnitOfWork _unitOfWork;

        public SaleOffController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: SaleOffController
        public ActionResult Index(int? cateId)
        {
            var data = _unitOfWork.CategoryRepository.GetAll();
            ViewBag.CateList = data;
            if (data != null)
            {
                if (cateId != null)
                {
                    ViewBag.CateId = cateId;
                    ViewBag.FlowerList = _unitOfWork.FlowerRepository.GetAll().Where(x => x.CategoryId == cateId);
                }
                else
                {
                    ViewBag.FlowerList = _unitOfWork.FlowerRepository.GetAll().Where(x => x.CategoryId == data[0].Id);
                }
            }

            return View();
        }
        // POST: SaleOffController/Create
        [HttpPost]
        public ActionResult Create(SaleOf saleOf)
        {
            try
            {
                Flower flower = _unitOfWork.FlowerRepository.Find(saleOf.FlowerId);
                flower.SalePrice = flower.Price - flower.Price * saleOf.SaleOffPercent / 100;
                _unitOfWork.FlowerRepository.Update(flower);
            }
            catch
            {

            }
            return Redirect("/Admin/Flower");
        }
    }
}
