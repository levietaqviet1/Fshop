using Microsoft.AspNetCore.Mvc;
using NWEB.Practice.T01.Core.Model;
using NWEB.Practice.T01.DataAccessLayer.UnitOfWork;

namespace NWEB.Practice.T01.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        // GET: CategoryController
        private IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            return View(_unitOfWork.CategoryRepository.GetAll());
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View(_unitOfWork.CategoryRepository.Find(id));
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                _unitOfWork.CategoryRepository.Add(category);
            }
            catch
            {

            }
            return Redirect("/Admin/Category/Index");
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_unitOfWork.CategoryRepository.Find(id));
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            try
            {
                _unitOfWork.CategoryRepository.Update(category);
            }
            catch
            {

            }
            return Redirect("/Admin/Category/Index");
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                _unitOfWork.CategoryRepository.Delete(id);
            }
            catch (Exception)
            {
            }

            return Redirect("/Admin/Category/Index");
        }
    }
}
