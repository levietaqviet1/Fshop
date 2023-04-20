using Microsoft.AspNetCore.Mvc;
using NWEB.Practice.T01.Core.Model;
using NWEB.Practice.T01.DataAccessLayer.UnitOfWork;

namespace NWEB.Practice.T01.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlowerController : Controller
    {
        // GET: CategoryController
        private IUnitOfWork _unitOfWork;

        public FlowerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: FlowerController
        public ActionResult Index()
        {
            IList<Flower> flowers = _unitOfWork.FlowerRepository.GetAll();
            foreach (Flower item in flowers)
            {
                item.Category = _unitOfWork.CategoryRepository.Find(item.CategoryId);
            }
            return View(flowers);
        }

        // GET: FlowerController/Details/5
        public ActionResult Details(int id)
        {
            Flower flower = _unitOfWork.FlowerRepository.Find(id);
            flower.Category = _unitOfWork.CategoryRepository.Find(flower.CategoryId);
            return View(flower);
        }

        // GET: FlowerController/Create
        public ActionResult Create()
        {
            ViewBag.CateList = _unitOfWork.CategoryRepository.GetAll();
            return View();
        }

        // POST: FlowerController/Create
        [HttpPost]
        public ActionResult Create(Flower flower)
        {
            try
            {
                _unitOfWork.FlowerRepository.Add(flower);
            }
            catch (Exception ex)
            {
            }
            return Redirect("/Admin/Flower/Index");
        }

        // GET: FlowerController/Edit/5
        public ActionResult Edit(int id)
        {
            Flower flower = _unitOfWork.FlowerRepository.Find(id);
            flower.Category = _unitOfWork.CategoryRepository.Find(flower.CategoryId);
            ViewBag.CateList = _unitOfWork.CategoryRepository.GetAll();
            return View(flower);
        }

        // POST: FlowerController/Edit/5
        [HttpPost]
        public ActionResult Edit(Flower flower)
        {
            try
            {
                _unitOfWork.FlowerRepository.Update(flower);
            }
            catch
            {
            }
            return Redirect("/Admin/Flower/Index");
        }

        // GET: FlowerController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                _unitOfWork.FlowerRepository.Delete(id);
            }
            catch (Exception)
            {
            }
            return Redirect("/Admin/Flower/Index");
        }

    }
}
