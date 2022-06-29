using MediatR;
using Microsoft.AspNetCore.Mvc;
using Posts.Application.Features.Categories.Queries.GetList;
using Posts.Application.Features.Categories.Queries.Get;
using Posts.Application.Features.Categories.Comands.Create;
using Posts.Application.Features.Categories.Comands.Delete;
using Posts.Application.Features.Categories.Comands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Posts.Application.DTO.CategoryDTO;
using AutoMapper;

namespace Posts.Presentation.Admin.Controllers
{
    public class CategoryController : Controller
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CategoryController(IMediator mediator,IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            var categoryList = _mediator.Send(new GetCategoryListQuery()).Result;
            return View(categoryList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CategoryCreateDTO());
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateDTO model)
        {
            if (ModelState.IsValid)
            {
                _mediator.Send( _mapper.Map<CreateCategoryCommand>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categoryUpdate = _mediator.Send(new GetCategoryQuery() { CategoryId = id }).Result;
            return View(categoryUpdate);
        }

        [HttpPost]
        public IActionResult Edit(CategoryUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                _mediator.Send(_mapper.Map<UpdateCategoryCommand>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            int z =_mediator.Send(new DeleteCategoryCommand() { Id = id }).Result;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var x = _mediator.Send(new GetCategoryQuery() { CategoryId = id }).Result;
            return View(x);
        }
    } 
}
