using AutoMapper;
using FA.JustBlog.Core.Models;
using FA.JustBlog.ViewModel.ViewModel;

namespace FA.JustBlog.Service.map
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<PostTagMap, PostTagMapViewModel>().ReverseMap();
            CreateMap<Comment, CommentViewModel>().ReverseMap();

            CreateMap<CategoryViewModel, Category>().ReverseMap();
            CreateMap<PostViewModel, Post>().ReverseMap();
            CreateMap<PostTagMapViewModel, PostTagMap>().ReverseMap();
            CreateMap<CommentViewModel, Comment>().ReverseMap();
        }
    }
}
