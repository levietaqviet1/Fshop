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

            CreateMap<Comment, CommentViewModel>();
            CreateMap<Post, PostViewModel>()
                .ForMember(dest => dest.CategoryViewModel, act => act.MapFrom(src => src.Category));

            CreateMap<PostTagMap, PostTagMapViewModel>();
            CreateMap<Tag, TagViewModel>();

            CreateMap<CategoryViewModel, Category>();
            CreateMap<PostViewModel, Post>();
            CreateMap<PostTagMapViewModel, PostTagMap>();
            CreateMap<CommentViewModel, Comment>();
            CreateMap<TagViewModel, Tag>();
        }
    }
}
