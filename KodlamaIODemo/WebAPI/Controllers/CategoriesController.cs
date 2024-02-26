using AutoMapper;
using Business.Abstracts;
using DTO.CategoryDtos;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("GetCategoryList")]
        public IActionResult CategoriesList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetAll());
            return Ok(value);
        }

        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);
            _categoryService.TAdd(value);
            return Ok("Kategori oluşturuldu !");
        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);
            _categoryService.TUpdate(value);
            return Ok("Kategori güncellendi !");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("DeleteCategory")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("Kategori silindi !");
        }
    }
}
