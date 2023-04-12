﻿using AutoMapper;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.UnitOfWork;
using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace FA.JustBlog.Service.tag
{
    public class TagService : ITagService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<UsingIdentityUser> _userManager;

        public TagService(IUnitOfWork unitOfWork = null, IMapper mapper = null, UserManager<UsingIdentityUser> userManager = null)
        {
            _unitOfWork = unitOfWork ?? new UnitOfWork();
            _mapper = mapper;
            _userManager = userManager;
        }
        public ResponseResult<TagViewModel> Add(TagViewModel tagViewModel)
        {
            try
            {
                var tag = _mapper.Map<Tag>(tagViewModel);
                _unitOfWork.TagRepository.Add(tag);
                return new ResponseResult<TagViewModel>
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<TagViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
        }

        public ResponseResult<TagViewModel> Delete(int id)
        {
            try
            {
                _unitOfWork.TagRepository.Delete(id);
                return new ResponseResult<TagViewModel>
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<TagViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
        }

        public ResponseResult<TagViewModel> GetAll()
        {
            ResponseResult<TagViewModel> response = new ResponseResult<TagViewModel>();
            try
            {
                IList<Tag> listTag = _unitOfWork.TagRepository.GetAll();
                if (listTag != null)
                {

                    var tagViewModel = _mapper.Map<List<TagViewModel>>(listTag);
                    response.DataList = tagViewModel;
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

        public ResponseResult<TagViewModel> GetById(int id)
        {
            ResponseResult<TagViewModel> response = new ResponseResult<TagViewModel>();
            try
            {
                Tag tag = _unitOfWork.TagRepository.Find(id);
                if (tag != null)
                {

                    var tagViewModel = _mapper.Map<TagViewModel>(tag);
                    response.Data = tagViewModel;
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

        public ResponseResult<TagViewModel> GetByUrl(string urlSlug)
        {
            ResponseResult<TagViewModel> response = new ResponseResult<TagViewModel>();
            try
            {
                Tag tag = _unitOfWork.TagRepository.GetTagByUrlSlug(urlSlug);
                if (tag != null)
                {

                    var tagViewModel = _mapper.Map<TagViewModel>(tag);
                    response.Data = tagViewModel;
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

        public ResponseResult<TagViewModel> Update(TagViewModel tagViewModel)
        {
            try
            {
                var tag = _mapper.Map<Tag>(tagViewModel);
                _unitOfWork.TagRepository.Update(tag);
                return new ResponseResult<TagViewModel>()
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                };
            }
            catch (Exception)
            {
                return new ResponseResult<TagViewModel>()
                {
                    StatusCode = 500,
                    IsSuccessed = false,
                };
            }
        }
    }
}
