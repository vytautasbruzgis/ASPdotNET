using _20220224_DanskeCredit_API.Dtos;
using _20220224_DanskeCredit_API.Exceptions;
using _20220224_DanskeCredit_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace _20220224_DanskeCredit_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanRequestController : ControllerBase
    {
        private LoanRequestService _loanRequestService;
        public LoanRequestController(LoanRequestService loanRequestService)
        {
            _loanRequestService = loanRequestService;
        }
        [HttpPost]
        public async Task<IActionResult> GetLoanRequestDecision(LoanRequestDto loanRequestDto)
        {
            try
            {
                var loanResponseDto = await _loanRequestService.CalculateRequestDecision(loanRequestDto);
                return Ok(loanResponseDto);
            } catch (LoanRequestBadArgumentException ex) { 
                return BadRequest(ex.errors);
            }
        }
    }
}
