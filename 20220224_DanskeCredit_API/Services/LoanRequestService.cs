using _20220224_DanskeCredit_API.Dtos;
using _20220224_DanskeCredit_API.Models;
using _20220224_DanskeCredit_API.Validators;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;
using _20220224_DanskeCredit_API.Exceptions;

namespace _20220224_DanskeCredit_API.Services
{
    public class LoanRequestService
    {
        const decimal _minCreditAmountValue = 2000;
        const decimal _maxCreditAmountValue = 69000;

        public List<PercentRateBoundaries> percentRateBoundaries = new List<PercentRateBoundaries>{
            new PercentRateBoundaries {
                PercentRate = 3,
                MinAmount = _minCreditAmountValue,
                MaxAmount = 19999
            },
            new PercentRateBoundaries {
                PercentRate = 4,
                MinAmount = 20000,
                MaxAmount = 39999
            },
            new PercentRateBoundaries {
                PercentRate = 5,
                MinAmount = 40000,
                MaxAmount = 59999
            },
            new PercentRateBoundaries {
                PercentRate = 6,
                MinAmount = 60000,
                MaxAmount = _maxCreditAmountValue
            }
        };

        public LoanRequestValidator validator;
        public LoanRequestService()
        {
            validator = new LoanRequestValidator();
        }
        public async Task<LoanResponseDto> CalculateRequestDecision(LoanRequestDto loanRequestDto)
        {
            var validationResult = validator.Validate(loanRequestDto);
            if (validationResult.IsValid) { 
                LoanResponseDto loanResponseDto = new LoanResponseDto();
                if (IsCreditAprovable(loanRequestDto.CreditAmount))
                {
                    loanResponseDto = CalculateCreditPercentRate(loanRequestDto);
                    loanResponseDto.RequestApproved = true;
                }
                return loanResponseDto;
            } else {
                List<string > errors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    errors.Add(error.ErrorMessage);
                }
                throw new LoanRequestBadArgumentException(errors);
            }
        }
        private bool IsCreditAprovable(decimal creditAmount)
        {
            if (creditAmount >= _minCreditAmountValue && creditAmount <= _maxCreditAmountValue)
            {
                return true;
            }
            return false;
        }
        private LoanResponseDto CalculateCreditPercentRate(LoanRequestDto loanRequestDto)
        {
            LoanResponseDto loanResponse = new LoanResponseDto();
            decimal totalFutureDebt = loanRequestDto.CurrentCreditAmount + loanRequestDto.CreditAmount;
            loanResponse.InterestPercentageRate = GetCreditPercentRate(totalFutureDebt);
            return loanResponse;
        }
        public decimal GetCreditPercentRate(decimal futureDebt)
        {
            int percentageRate = 0;
            foreach (var percentRateBoundary in percentRateBoundaries)
            {
                if (futureDebt >= percentRateBoundary.MinAmount && futureDebt <= percentRateBoundary.MaxAmount)
                {
                    return percentRateBoundary.PercentRate;
                }
            }
            return percentageRate;
        }
    }
}
