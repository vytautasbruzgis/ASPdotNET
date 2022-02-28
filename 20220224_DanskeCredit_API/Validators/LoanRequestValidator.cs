using _20220224_DanskeCredit_API.Dtos;
using FluentValidation;

namespace _20220224_DanskeCredit_API.Validators
{
    public class LoanRequestValidator : AbstractValidator<LoanRequestDto>
    {
        public LoanRequestValidator()
        {
            RuleFor(x => x.CreditAmount).GreaterThan(0);
            RuleFor(x => x.TermMonths).GreaterThan(0);
            RuleFor(x => x.CurrentCreditAmount).GreaterThanOrEqualTo(0);
            //RuleFor(x => x.CreditAmount).Custom((CreditAmount, context) => {
            //    if (CreditAmount > 10)
            //    {
            //        context.AddFailure("The list must contain 10 items or fewer");
            //    }
            //});
        } 
    }
}
