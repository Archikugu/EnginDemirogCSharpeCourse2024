using AutoMapper;
using Business.Abstracts;
using DTO.CourseDtos;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CoursesController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        [HttpGet("GetCourseList")]
        public IActionResult CourseList()
        {
            var value = _mapper.Map<List<ResultCourseDto>>(_courseService.TGetAll());
            return Ok(value);
        }

        [HttpPost("CreateCourse")]
        public IActionResult CreateCourse(CreateCourseDto createCourseDto)
        {
            var value = _mapper.Map<Course>(createCourseDto);
            _courseService.TAdd(value);
            return Ok("Kurs oluşturuldu !");
        }

        [HttpPut("UpdateCourse")]
        public IActionResult UpdateCourse(UpdateCourseDto updateCourseDto)
        {
            var value = _mapper.Map<Course>(updateCourseDto);
            _courseService.TUpdate(value);
            return Ok("Kurs güncellendi !");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _courseService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("DeleteCourse")]
        public IActionResult DeleteCourse(int id)
        {
            var value = _courseService.TGetById(id);
            _courseService.TDelete(value);
            return Ok("Kurs silindi !");
        }
    }
}
