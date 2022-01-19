using _20220107_HotelCleaning.Models.Dtos;
using AutoMapper;

namespace _20220107_HotelCleaning.Models.Automapper
{
    public class HotelTaskProfile : Profile
    {
        public HotelTaskProfile()
        {
            CreateMap<HotelTask, HotelTaskDto>();
            CreateMap<HotelTaskDto, HotelTask>();
        }
    }
    public class HotelTaskProfile_2 : Profile
    {
        public HotelTaskProfile_2()
        {
            CreateMap<HotelTask, HotelTaskDto>();
            CreateMap<HotelTaskDto, HotelTask>();
        }
    }
    
}
