
using AutoMapper;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.UnitOfWork;
using FA.JustBlog.Core.Utill;
using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;

namespace FA.JustBlog.Service.category
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork unitOfWork = null, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork ?? new UnitOfWork();

            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<Category, CategoryViewModel>().ReverseMap();
            });

            this._mapper = mapper ?? config.CreateMapper();

        }

        public ResponseResult<CategoryViewModel> Add(CategoryViewModel categoryViewModel)
        {
            try
            {
                var categoryModels = _mapper.Map<Category>(categoryViewModel);
                categoryModels.UrlSlug = Utils.ConFigUrlSlug(categoryViewModel.Name);

                Category dataCheck = null;
                int randomNum = Utils.RandomInt(5, 20);
                do
                {
                    dataCheck = _unitOfWork.CategoryRepository.GetTagByUrlSlug(categoryModels.UrlSlug);
                    categoryModels.UrlSlug += "-" + Utils.RandomString(randomNum);
                } while (dataCheck == null);

                _unitOfWork.CategoryRepository.Add(categoryModels);
                categoryViewModel.UrlSlug = categoryModels.UrlSlug;
                return new ResponseResult<CategoryViewModel>()
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                    Data = categoryViewModel
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<CategoryViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }


        }

        public ResponseResult<CategoryViewModel> Delete(int id)
        {
            try
            {
                _unitOfWork.CategoryRepository.Delete(id);
                return new ResponseResult<CategoryViewModel>
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<CategoryViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
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

                var categoryModels = _mapper.Map<List<CategoryViewModel>>(categorys);
                return new ResponseResult<CategoryViewModel>()
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                    DataList = categoryModels,
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                response.Message = "Loi 500 Server: " + ex.Message;
                response.StatusCode = 500;
            }
            return response;
        }

        public ResponseResult<CategoryViewModel> GetById(int id)
        {
            try
            {
                var category = _unitOfWork.CategoryRepository.Find(id);
                var categoryModel = _mapper.Map<CategoryViewModel>(category);
                return new ResponseResult<CategoryViewModel>()
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                    Data = categoryModel
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<CategoryViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
        }

        public ResponseResult<CategoryViewModel> Update(CategoryViewModel categoryViewModel)
        {
            try
            {
                Category category = _unitOfWork.CategoryRepository.Find(categoryViewModel.Id);

                if (category == null)
                {
                    return new ResponseResult<CategoryViewModel>()
                    {
                        Message = "No Data",
                        StatusCode = 404,
                    };
                }

                category.Name = categoryViewModel.Name;
                category.Description = categoryViewModel.Description;
                category.UrlSlug = Utils.ConFigUrlSlug(category.Name);

                if (!category.Name.Equals(categoryViewModel.Name))
                {
                    Category dataCheck = null;
                    int randomNum = Utils.RandomInt(5, 20);
                    do
                    {
                        dataCheck = _unitOfWork.CategoryRepository.GetTagByUrlSlug(category.UrlSlug);
                        category.UrlSlug += "-" + Utils.RandomString(randomNum);
                    } while (dataCheck == null);
                }

                _unitOfWork.CategoryRepository.Update(category);
                categoryViewModel.UrlSlug = category.UrlSlug;
                return new ResponseResult<CategoryViewModel>()
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                    Data = categoryViewModel
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<CategoryViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
        }
    }
}
