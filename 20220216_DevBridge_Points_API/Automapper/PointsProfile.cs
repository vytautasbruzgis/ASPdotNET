using _20220216_DevBridge_Points_API.Dtos;
using _20220216_DevBridge_Points_API.Models;
using AutoMapper;

namespace _20220216_DevBridge_Points_API.AutoMapper
{
    public class PointsProfile : Profile
    {
        public PointsProfile()
        {
            CreateMap<Point, PointDto>().ReverseMap();
            CreateMap<PointCreateDto, PointDto>().ReverseMap();
            //CreateMap<Student, StudentDto>()
            //    .ForMember(dest => dest.FullName, act => act.MapFrom(src => src.FullName))
            //    .ReverseMap();
            //CreateMap<SchoolCreateDto, School>();
            //CreateMap<Item, ItemDto>().ReverseMap();
            //CreateMap<School, SchoolDto>().ForMember(dest => dest.CompleteUntil, act => act.MapFrom(src => src.CompleteUntil));
        }
    }
}
