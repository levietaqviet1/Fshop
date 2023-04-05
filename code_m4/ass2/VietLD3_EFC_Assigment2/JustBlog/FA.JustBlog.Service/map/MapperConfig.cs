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

        }
    }
}
