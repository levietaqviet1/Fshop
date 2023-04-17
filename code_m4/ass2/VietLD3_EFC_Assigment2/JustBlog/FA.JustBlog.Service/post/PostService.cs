using AutoMapper;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.UnitOfWork;
using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace FA.JustBlog.Service.post
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<UsingIdentityUser> _userManager;

        public PostService(IUnitOfWork unitOfWork = null, IMapper mapper = null, UserManager<UsingIdentityUser> userManager = null)
        {
            _unitOfWork = unitOfWork ?? new UnitOfWork();
            _mapper = mapper;
            _userManager = userManager;

        }
        public ResponseResult<PostViewModel> Add(PostViewModel postViewModel)
        {
            try
            {
                var post = _mapper.Map<Post>(postViewModel);
                post.Modified = DateTime.UtcNow;
                _unitOfWork.PostRepository.Add(post);
                return new ResponseResult<PostViewModel>
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<PostViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
        }

        public ResponseResult<PostViewModel> Delete(int id)
        {
            try
            {
                _unitOfWork.PostRepository.Delete(id);
                return new ResponseResult<PostViewModel>
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<PostViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message,
                };
            }
        }

        public ResponseResult<PostViewModel> GetAll(string? tagUrlSlug, string? cateUrlSlug)
        {
            ResponseResult<PostViewModel> response = new ResponseResult<PostViewModel>();
            try
            {
                IList<Post> listPost = _unitOfWork.PostRepository.GetAll().OrderByDescending(x => x.PostedOn).ToArray();

                if (listPost != null)
                {
                    foreach (Post post in listPost)
                    {
                        post.PostTagMaps = _unitOfWork.PostTagMapRepository.GetByPost(post.Id);
                        post.Comments = _unitOfWork.CommentRepository.GetAll().Where(x => x.PostId == post.Id).ToList();
                        foreach (Comment comment in post.Comments)
                        {
                            comment.UsingIdentityUser = _userManager.FindByIdAsync(comment.UsingIdentityUserId).Result;
                        }
                        post.UsingIdentityUser = _userManager.FindByIdAsync(post.UsingIdentityUserId).Result;
                        post.Category = _unitOfWork.CategoryRepository.Find(post.CategoryId);
                    }

                    if (tagUrlSlug != null)
                    {
                        listPost = listPost.Where(x => x.PostTagMaps.Any(z => z.Tag.UrlSlug == tagUrlSlug)).ToArray();
                    }
                    if (cateUrlSlug != null)
                    {
                        listPost = listPost.Where(x => x.Category.UrlSlug == cateUrlSlug).ToArray();
                    }
                    var postViewModel = _mapper.Map<List<PostViewModel>>(listPost);
                    response.DataList = postViewModel;
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

        public ResponseResult<PostViewModel> GetById(int id)
        {
            ResponseResult<PostViewModel> response = new ResponseResult<PostViewModel>();
            try
            {
                Post post1 = _unitOfWork.PostRepository.Find(id);
                if (post1 != null)
                {
                    post1.PostTagMaps = _unitOfWork.PostTagMapRepository.GetByPost(post1.Id);
                    post1.Comments = _unitOfWork.CommentRepository.GetAll().Where(x => x.PostId == post1.Id).ToList();
                    post1.UsingIdentityUser = _userManager.FindByIdAsync(post1.UsingIdentityUserId).Result;
                    var postViewModel = _mapper.Map<PostViewModel>(post1);
                    response.Data = postViewModel;
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

        public ResponseResult<PostViewModel> GetByUrl(string urlSlug)
        {
            ResponseResult<PostViewModel> response = new ResponseResult<PostViewModel>();
            try
            {
                Post post1 = _unitOfWork.PostRepository.GetPostsByUrlSlug(urlSlug);
                if (post1 != null)
                {
                    post1.PostTagMaps = _unitOfWork.PostTagMapRepository.GetByPost(post1.Id);
                    post1.Comments = _unitOfWork.CommentRepository.GetAll().Where(x => x.PostId == post1.Id).ToList();
                    foreach (Comment comment in post1.Comments)
                    {
                        comment.UsingIdentityUser = _userManager.FindByIdAsync(comment.UsingIdentityUserId).Result;
                    }
                    post1.UsingIdentityUser = _userManager.FindByIdAsync(post1.UsingIdentityUserId).Result;
                    var postViewModel = _mapper.Map<PostViewModel>(post1);
                    response.Data = postViewModel;
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

        public ResponseResult<PostViewModel> GetMostView(string? tagUrlSlug, string? cateUrlSlug)
        {
            ResponseResult<PostViewModel> response = new ResponseResult<PostViewModel>();
            try
            {
                IList<Post> listPost = _unitOfWork.PostRepository.GetAll().OrderByDescending(x => x.ViewCount).ToArray();

                if (listPost != null)
                {
                    foreach (Post post in listPost)
                    {
                        post.PostTagMaps = _unitOfWork.PostTagMapRepository.GetByPost(post.Id);
                        post.Comments = _unitOfWork.CommentRepository.GetAll().Where(x => x.PostId == post.Id).ToList();
                        post.UsingIdentityUser = _userManager.FindByIdAsync(post.UsingIdentityUserId).Result;
                        post.Category = _unitOfWork.CategoryRepository.Find(post.CategoryId);
                    }
                    if (tagUrlSlug != null)
                    {
                        listPost = listPost.Where(x => x.PostTagMaps.Any(z => z.Tag.UrlSlug == tagUrlSlug)).ToArray();
                    }
                    if (cateUrlSlug != null)
                    {
                        listPost = listPost.Where(x => x.Category.UrlSlug == cateUrlSlug).ToArray();
                    }
                    List<PostViewModel> postViewModel = _mapper.Map<List<PostViewModel>>(listPost.Take(5));

                    response.DataList = postViewModel;
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

        public ResponseResult<PostViewModel> Update(PostViewModel postViewModel)
        {
            try
            {
                Post post = _unitOfWork.PostRepository.Find(postViewModel.Id);
                if (post == null)
                {
                    return new ResponseResult<PostViewModel>()
                    {
                        Message = "No Data",
                        StatusCode = 404,
                    };
                }

                post.Title = postViewModel.Title;
                post.UrlSlug = postViewModel.UrlSlug;
                post.ShortDescription = postViewModel.ShortDescription;
                post.Published = postViewModel.Published;
                post.Modified = DateTime.Now;
                post.ViewCount = postViewModel.ViewCount;
                post.RateCount = postViewModel.RateCount;
                post.TotalRate = postViewModel.TotalRate;
                post.CategoryId = postViewModel.CategoryId;
                _unitOfWork.PostRepository.Update(post);

                return new ResponseResult<PostViewModel>()
                {
                    StatusCode = 200,
                    IsSuccessed = true,
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult<PostViewModel>
                {
                    StatusCode = 500,
                    Message = ex.Message
                };
            }
        }
    }
}
