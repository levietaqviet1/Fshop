using AutoMapper;
using FA.JustBlog.Core.Repositories.UnitOfWork;
using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;

namespace FA.JustBlog.Service.category
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;
        public CategoryService(IUnitOfWork unitOfWork = null)
        {
            _unitOfWork = unitOfWork ?? new UnitOfWork();
        }
        public ResponseResult<CategoryViewModel> GetAll()
        {
            ResponseResult<CategoryViewModel> response = new ResponseResult<CategoryViewModel>();
            try
            {
                var categorys = _unitOfWork.CategoryRepository.GetAll();
                if (categorys == null || categorys.Count == 0)
                {
                    return new ResponseResult<CategoryViewModel>()
                    {
                        Message = "No Data",
                        StatusCode = 404,
                    };
                }

                var categoryModels = mapper.Map<List<CategoryViewModel>>(categorys);
                return new ResponseResult<CategoryViewModel>()
                {
                    DataList = categoryModels,
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                response.Message = "Loi 500 Server";
                response.StatusCode = 500;
            }
            return response;
        }
    }
}
