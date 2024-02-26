using AutoMapper;
using DTO.InstructorDtos;
using Entities.Concretes;

namespace WebAPI.Mapping
{
    public class InstructorMapping : Profile
    {
        public InstructorMapping()
        {
            CreateMap<Instructor, CreateInstructorDto>().ReverseMap();
            CreateMap<Instructor, ResultInstructorDto>().ReverseMap();
            CreateMap<Instructor, UpdateInstructorDto>().ReverseMap();
        }
    }
}
