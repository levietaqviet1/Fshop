using AutoMapper;
using FA.JustBlog.Core.Models;
using FA.JustBlog.ViewModel.ViewModel;

namespace FA.JustBlog.Service.map
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<PostTagMap, PostTagMapViewModel>();
            CreateMap<Comment, CommentViewModel>();
            CreateMap<Post, PostViewModel>()
                .ForMember(dest => dest.CategoryViewModel, act => act.MapFrom(src => src.Category));
            CreateMap<Tag, TagViewModel>();

            CreateMap<CategoryViewModel, Category>();
            CreateMap<PostTagMapViewModel, PostTagMap>();
            CreateMap<PostViewModel, Post>()
                .ForMember(dest => dest.Category, act => act.MapFrom(src => src.CategoryViewModel));
            CreateMap<CommentViewModel, Comment>();
            CreateMap<TagViewModel, Tag>();
        }
    }
}
