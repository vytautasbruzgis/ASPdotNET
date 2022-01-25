using _20210118_School_API.Services;
using _20220121_Shop_API.Dtos;
using _20220121_Shop_API.Models;
using _20220121_Shop_API.Repositories;
using _20220121_Shop_API.Validators;
using AutoMapper;
using FluentValidation;
using System;

namespace _20220121_Shop_API.Services
{
    public class ShopService : ServiceNamedBase<Shop, ShopRepository, ShopDto>
    {
        public ShopService(ShopRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public ShopDto GetByIdIncluded(int shopId)
        {
            Shop shop = _repo.GetByIdIncluded(shopId);
            ShopDto shopDto = _mapper.Map<ShopDto>(shop);
            return shopDto;   
        }

        public int Create(ShopCreateDto shopCreateDto)
        {
            if (IsNameUnique(shopCreateDto.Name))
            {
                ShopDto shopDto = new ShopDto
                {
                    Name = shopCreateDto.Name
                };
                ShopValidator validator = new ShopValidator();
                validator.ValidateAndThrow(shopDto);
                return base.Create(shopDto);
            } else
            {
                throw new ArgumentException("Shop name is not unique");
            }                
        }
    }
}
