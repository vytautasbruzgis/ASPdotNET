using _20220121_Shop_API.Dtos;
using _20220121_Shop_API.Models;
using AutoMapper;

namespace _20220118_Shop_API.AutoMapper
{
    public class ShopProfile : Profile
    {
        public ShopProfile()
        {
            CreateMap<ShopItem, ShopItemDto>().ReverseMap();
            CreateMap<Shop, ShopDto>().ReverseMap();
            CreateMap<Shop, ShopCreateDto>().ReverseMap();
            CreateMap<Item, ItemDto>().ReverseMap();
            //CreateMap<ToDoDto, ToDo>().ForMember(dest => dest.CompleteUntil, act => act.MapFrom(src => src.CompleteUntil));
        }
    }
}
