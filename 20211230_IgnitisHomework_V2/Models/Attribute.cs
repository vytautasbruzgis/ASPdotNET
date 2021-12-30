using System.Collections.Generic;

namespace _20211230_IgnitisHomework_V2.Models
{
    public class Attribute : NamedEntity
    {
        public List<AttributeOption> Options { get; set; }
        public List<RegistrationAttribute> RegistrationAttributes { get; set; }
    }
}
