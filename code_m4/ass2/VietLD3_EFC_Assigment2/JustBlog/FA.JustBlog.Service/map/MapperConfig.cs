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

                .ForMember(dest => dest.CategoryViewModel, act => act.MapFrom(src => src.Category))
                .ForMember(dest => dest.PostTagMapsViewModel, act => act.MapFrom(src => src.PostTagMaps))
               // .IncludeMembers(x=> x.PostTagMaps, z=> z.);

            CreateMap<PostTagMap, PostTagMapViewModel>();

            //CreateMap<CategoryViewModel, Category>().ReverseMap();
            //CreateMap<PostViewModel, Post>().ReverseMap();
            //CreateMap<PostTagMapViewModel, PostTagMap>().ReverseMap();
            //CreateMap<CommentViewModel, Comment>().ReverseMap();
        }
    }
}
