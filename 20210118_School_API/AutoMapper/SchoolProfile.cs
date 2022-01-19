using _20210118_School_API.Dtos;
using _20210118_School_API.Models;
using AutoMapper;

namespace _20220118_School_API.AutoMapper
{
    public class SchoolProfile : Profile
    {
        public SchoolProfile()
        {
            CreateMap<School, SchoolDto>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();//.ForMember(dest => dest.CompleteUntil, act => act.MapFrom(src => src.CompleteUntil));
        }
    }
}
