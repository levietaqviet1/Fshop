using AutoMapper;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.UnitOfWork;
using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace FA.JustBlog.Service.comment
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<UsingIdentityUser> _userManager;

        public CommentService(IUnitOfWork unitOfWork = null, IMapper mapper = null, UserManager<UsingIdentityUser> userManager = null)
        {
            _unitOfWork = unitOfWork ?? new UnitOfWork();
            _mapper = mapper;
            _userManager = userManager;

        }
        public ResponseResult<CommentViewModel> Add(CommentViewModel commentViewModel)
        {
            try
            {
                var comment = _mapper.Map<Comment>(commentViewModel);
                _unitOfWork.CommentRepository.Add(comment);
                return new ResponseResult<CommentViewModel>
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<CommentViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
        }

        public ResponseResult<CommentViewModel> Delete(int id)
        {
            try
            {
                _unitOfWork.CommentRepository.Delete(id);
                return new ResponseResult<CommentViewModel>
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<CommentViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
        }

        public ResponseResult<CommentViewModel> GetAll()
        {
            ResponseResult<CommentViewModel> response = new ResponseResult<CommentViewModel>();
            try
            {
                IList<Comment> listComment = _unitOfWork.CommentRepository.GetAll().ToArray();

                if (listComment != null)
                {
                    foreach (Comment item in listComment)
                    {
                        item.UsingIdentityUser = _userManager.FindByIdAsync(item.UsingIdentityUserId).Result;
                        item.Post = _unitOfWork.PostRepository.Find(item.PostId);
                    }


                    var commentViews = _mapper.Map<List<CommentViewModel>>(listComment);
                    response.DataList = commentViews;
                    response.IsSuccessed = true;
                    response.StatusCode = 200;
                }
                else
                {
                    response.IsSuccessed = false;
                    response.Message = "No Data";
                    response.StatusCode = 404;
                }

            }
            catch (Exception ex)
            {
                response.Message = "Loi 500 Server: " + ex.Message;
                response.StatusCode = 500;
            }
            return response;
        }

        public ResponseResult<CommentViewModel> GetById(int id)
        {
            ResponseResult<CommentViewModel> response = new ResponseResult<CommentViewModel>();
            try
            {
                Comment comment = _unitOfWork.CommentRepository.Find(id);

                if (comment != null)
                {
                    comment.UsingIdentityUser = _userManager.FindByIdAsync(comment.UsingIdentityUserId).Result;



                    var commentViews = _mapper.Map<CommentViewModel>(comment);
                    response.Data = commentViews;
                    response.IsSuccessed = true;
                    response.StatusCode = 200;
                }
                else
                {
                    response.IsSuccessed = false;
                    response.Message = "No Data";
                    response.StatusCode = 404;
                }

            }
            catch (Exception ex)
            {
                response.Message = "Loi 500 Server: " + ex.Message;
                response.StatusCode = 500;
            }
            return response;
        }

        public ResponseResult<CommentViewModel> Update(CommentViewModel commentViewModel)
        {
            try
            {
                Comment comment = _unitOfWork.CommentRepository.Find(commentViewModel.Id);

                if (comment == null)
                {
                    return new ResponseResult<CommentViewModel>()
                    {
                        Message = "No Data",
                        StatusCode = 404,
                    };
                }

                comment.CommentHeader = commentViewModel.CommentHeader;
                comment.CommentText = commentViewModel.CommentText;
                comment.CommentTime = DateTime.UtcNow;
                _unitOfWork.CommentRepository.Update(comment);
                return new ResponseResult<CommentViewModel>()
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<CommentViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
        }
    }
}
