using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.UnitOfWork;
using FA.JustBlog.Service.map;
using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;

namespace FA.JustBlog.Service.category
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly MapperConfig mapperConfig;
        public CategoryService(IUnitOfWork unitOfWork = null)
        {
            _unitOfWork = unitOfWork ?? new UnitOfWork();
        }
        public ResponseResult<CategoryViewModel> GetAll()
        {
            ResponseResult<Category> response = new ResponseResult<Category>();
            try
            {
                var data = _unitOfWork.CategoryRepository.GetAll();
                if (data == null || data.Count == 0)
                {
                    return new ResponseResult<CategoryViewModel>()
                    {
                        Message = "No Data",
                        StatusCode = 404,
                    };
                }

                var dataModels = ma
            }
            catch (Exception ex)
            {


            }

        }
    }
}
