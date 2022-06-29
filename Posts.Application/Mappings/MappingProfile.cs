using AutoMapper;
using Posts.Application.DTO.CategoryDTO;
using Posts.Application.DTO.PostDTO;
using Posts.Application.Features.Categories.Comands.Create;
using Posts.Application.Features.Categories.Comands.Update;
using Posts.Application.Features.Posts.Comands.Create;
using Posts.Application.Features.Posts.Comands.Update;
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
            CreateMap<CreatePostCommand, PostCreateDTO>().ReverseMap();
            CreateMap<Post, PostDTO>().ReverseMap();
            CreateMap<PostDTO, PostUpdateDTO>().ReverseMap();
            CreateMap<Post, PostUpdateDTO>().ReverseMap();
            CreateMap<UpdatePostCommand, PostUpdateDTO>().ReverseMap();

            CreateMap<Category, CategoryCreateDTO>().ReverseMap();
            CreateMap<CreateCategoryCommand, CategoryCreateDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryUpdateDTO>().ReverseMap();
            CreateMap<UpdateCategoryCommand, CategoryUpdateDTO>().ReverseMap();
        }
    }
}
