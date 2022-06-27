using AutoMapper;
using Posts.Application.DTO.CategoryDTO;
using Posts.Application.DTO.PostDTO;
using Posts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostCreateDTO>().ReverseMap();
            CreateMap<Post, PostDTO>().ReverseMap();
            CreateMap<Post, PostUpdateDTO>().ReverseMap();

            CreateMap<Category, CategoryCreateDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryUpdateDTO>().ReverseMap();
        }
    }
}
