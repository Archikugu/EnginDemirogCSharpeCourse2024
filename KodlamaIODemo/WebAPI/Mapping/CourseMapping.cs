using AutoMapper;
using DTO.CourseDtos;
using Entities.Concretes;

namespace WebAPI.Mapping
{
    public class CourseMapping : Profile
    {
        public CourseMapping()
        {
            CreateMap<Course, CreateCourseDto>().ReverseMap();
            CreateMap<Course, ResultCourseDto>().ReverseMap();
            CreateMap<Course, UpdateCourseDto>().ReverseMap();
        }
    }
}
