using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Posts.Application.DTO.PostDTO;
using Posts.Application.Features.Categories.Queries.GetList;
using Posts.Application.Features.Posts.Comands.Create;
using Posts.Application.Features.Posts.Comands.Delete;
using Posts.Application.Features.Posts.Comands.Update;
using Posts.Application.Features.Posts.Queries.Get;
using Posts.Application.Features.Posts.Queries.GetList;
using Posts.Presentation.Admin.Models.PostVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Posts.Presentation.Admin.Controllers
{
    public class PostController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public PostController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(_mediator.Send(new GetPostListQuery()).Result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            PostCreateVM model = new()
            {
                CategoryList = _mediator.Send(new GetCategoryListQuery()).Result.List
                .Select(x => new SelectListItem()
                {
                    Value = x.Id.ToString(),
                    Text = x.Title
                })
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(PostCreateVM model)
        {
            if (ModelState.IsValid)
            {
                _mediator.Send(_mapper.Map<CreatePostCommand>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            PostEditVM model=new();
            model.OldVersion=_mapper.Map<PostUpdateDTO>(_mediator.Send(new GetPostQuery() {PostId=id }).Result);
            model.CategoryList = _mediator.Send(new GetCategoryListQuery()).Result.List
            .Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Title
            });
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(PostEditVM model)
        {
            if (ModelState.IsValid)
            {
                _mediator.Send(_mapper.Map<UpdatePostCommand>(model.OldVersion));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            int z = _mediator.Send(new DeletePostCommand() { Id = id }).Result;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var x = _mediator.Send(new GetPostQuery() { PostId = id }).Result;
            return View(x);
        }
    }
}
