namespace _20211228_IgnitisHomeWork.Models
{
    public class RegistrationattributesModel : Entity
    {
        public bool HasContractWork { get; set; }
        public int ContractorTypeId { get; set; }
        public ContractorTypeModel ContractorType { get; set; }
        public bool IsBusinessClient { get; set; }
        public int CalculationTypeId { get; set; }
        public CalculationTypeModel CalculationType { get; set; }
        public int CustomerImportanceId { get; set; }
        public CustomerImportanceModel CustomerImportance { get; set; }
    }
}
