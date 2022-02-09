using _20220121_Shop_API.Dtos;
using _20220121_Shop_API.Models;
using _20220121_Shop_API.Repositories;
using AutoMapper;

namespace _20220121_Shop_API.Services
{
    public class ItemService : ServiceBase<Item, ItemRepository, ItemDto>
    {
        public ItemService(ItemRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
