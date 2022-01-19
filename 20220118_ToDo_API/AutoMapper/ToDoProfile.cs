using _20220118_School_API.Dtos;
using _20220118_School_API.Models;
using AutoMapper;

namespace _20220118_School_API.AutoMapper
{
    public class ToDoProfile : Profile
    {
        public ToDoProfile()
        {
            CreateMap<ToDo, ToDoDto>();
            CreateMap<ToDoDto, ToDo>().ForMember(dest => dest.CompleteUntil, act => act.MapFrom(src => src.CompleteUntil));
        }
    }
}
