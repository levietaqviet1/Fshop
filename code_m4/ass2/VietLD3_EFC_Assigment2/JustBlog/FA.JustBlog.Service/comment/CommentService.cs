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
            throw new NotImplementedException();
        }

        public ResponseResult<CommentViewModel> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseResult<CommentViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseResult<CommentViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseResult<CommentViewModel> Update(CommentViewModel commentViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
