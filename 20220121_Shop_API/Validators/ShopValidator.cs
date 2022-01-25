using _20220121_Shop_API.Dtos;
using _20220121_Shop_API.Models;
using FluentValidation;

namespace _20220121_Shop_API.Validators
{
    public class ShopValidator : AbstractValidator<ShopDto>
    {
        public ShopValidator()
        {
            RuleFor(x => x.Name).MinimumLength(4);
        }
    }
}
