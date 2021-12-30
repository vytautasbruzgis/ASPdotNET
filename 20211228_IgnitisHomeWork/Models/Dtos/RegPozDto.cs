using System.Collections.Generic;

namespace _20211230_IgnitisHomeWork_V2.Models.Dtos
{
    public class RegPozDto
    {
        public RegistrationattributesModel Registrationattributes { get; set; }
        public List<ContractorTypeModel> ContractorTypes { get; set; }
        public List<CalculationTypeModel> CalculationTypes { get; set; }
        public List<CustomerImportanceModel> CustomerImportances { get; set; }
    }
}
