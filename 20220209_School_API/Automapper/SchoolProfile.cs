using _20220209_School_API.Dtos;
using _20220209_School_API.Models;
using AutoMapper;

namespace _20220209_School_API.AutoMapper
{
    public class SchoolProfile : Profile
    {
        public SchoolProfile()
        {
            CreateMap<School, SchoolDto>()
                .ReverseMap();
            CreateMap<Student, StudentDto>()
                .ForMember(dest => dest.FullName, act => act.MapFrom(src => src.FullName))
                .ReverseMap();
            //CreateMap<SchoolCreateDto, School>();
            //CreateMap<Item, ItemDto>().ReverseMap();
            //CreateMap<School, SchoolDto>().ForMember(dest => dest.CompleteUntil, act => act.MapFrom(src => src.CompleteUntil));
        }
    }
}
