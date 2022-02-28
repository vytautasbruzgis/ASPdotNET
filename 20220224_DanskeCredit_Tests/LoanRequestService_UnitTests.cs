using _20220224_DanskeCredit_API.Dtos;
using _20220224_DanskeCredit_API.Exceptions;
using _20220224_DanskeCredit_API.Services;
using AutoFixture;
using System;
using System.Threading.Tasks;
using Xunit;

namespace _20220224_DanskeCredit_Tests
{
    public class LoanRequestService_UnitTests
    {
        /* Assuming that FluentValidation works good :) No custom methods */

        private LoanRequestService _loanRequestService;
        private Fixture _fixture = new Fixture();
        private Random _random = new Random();
        
        public LoanRequestService_UnitTests()
        {
            _loanRequestService = new LoanRequestService();
        }

        [Fact]
        public async Task CalculateRequestDecision_Validation_GivenInvalidArgument_CreditAmount_ThrowsArgumentException()
        {
            var randomLoanRequestDto = new LoanRequestDto()
            {
                CreditAmount = 0,
                TermMonths = 1,
                CurrentCreditAmount = 0
            };
            await Assert.ThrowsAsync<LoanRequestBadArgumentException>(() => _loanRequestService.CalculateRequestDecision(randomLoanRequestDto));
        }
        [Fact]
        public async Task CalculateRequestDecision_Validation_GivenInvalidArgument_TermMonths_ThrowsArgumentException()
        {
            var randomLoanRequestDto = new LoanRequestDto()
            {
                CreditAmount = 1000,
                TermMonths = 0,
                CurrentCreditAmount = 5001
            };
            await Assert.ThrowsAsync<LoanRequestBadArgumentException>(() => _loanRequestService.CalculateRequestDecision(randomLoanRequestDto));
        }
        [Fact]
        public async Task CalculateRequestDecision_Validation_GivenInvalidArgument_CurrentCreditAmount_ThrowsArgumentException()
        {
            var randomLoanRequestDto = new LoanRequestDto()
            {
                CreditAmount = 1000,
                TermMonths = 2,
                CurrentCreditAmount = -500
            };
            await Assert.ThrowsAsync<LoanRequestBadArgumentException>(() => _loanRequestService.CalculateRequestDecision(randomLoanRequestDto));
        }
        public async Task CalculateRequestDecision_Validation_GivenInvalidArgument_CurrentCreditAmount_ThrowsArgumentException()
        {
            var randomLoanRequestDto = new LoanRequestDto()
            {
                CreditAmount = 1000,
                TermMonths = 2,
                CurrentCreditAmount = -500
            };
            await Assert.ThrowsAsync<LoanRequestBadArgumentException>(() => _loanRequestService.CalculateRequestDecision(randomLoanRequestDto));
        }

    }
}
