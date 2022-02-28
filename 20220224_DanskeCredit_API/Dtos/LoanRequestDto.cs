namespace _20220224_DanskeCredit_API.Dtos
{
    public class LoanRequestDto
    {
        public decimal CreditAmount { get; set; }
        public int TermMonths { get; set; }
        public decimal CurrentCreditAmount { get; set; }
    }
}
