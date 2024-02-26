using AutoMapper;
using Business.Abstracts;
using DTO.InstructorDtos;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly IInstructorService _instructorService;
        private readonly IMapper _mapper;

        public InstructorsController(IInstructorService instructorService, IMapper mapper)
        {
            _instructorService = instructorService;
            _mapper = mapper;
        }

        [HttpGet("GetInstructorList")]
        public IActionResult InstructorsList()
        {
            var value = _mapper.Map<List<ResultInstructorDto>>(_instructorService.TGetAll());
            return Ok(value);
        }

        [HttpPost("CreateInstructor")]
        public IActionResult CreateInstructor(CreateInstructorDto createInstructorDto)
        {
            var value = _mapper.Map<Instructor>(createInstructorDto);
            _instructorService.TAdd(value);
            return Ok("Eğitmen oluşturuldu !");
        }

        [HttpPut("UpdateInstructor")]
        public IActionResult UpdateInstructor(UpdateInstructorDto updateInstructorDto)
        {
            var value = _mapper.Map<Instructor>(updateInstructorDto);
            _instructorService.TUpdate(value);
            return Ok("Eğitmen güncellendi !");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _instructorService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("DeleteInstructor")]
        public IActionResult DeleteInstructor(int id)
        {
            var value = _instructorService.TGetById(id);
            _instructorService.TDelete(value);
            return Ok("Eğitmen silindi !");
        }
    }
}
