using _20220216_DevBridge_Points_API.Dtos;
using FluentValidation;

namespace _20220216_DevBridge_Points_API.Validators
{
    public class PointListValidator : AbstractValidator<PointListCreateDto>
    {
        public PointListValidator()
        {
            RuleFor(x => x.Name).MinimumLength(4);
        }
    }
}
