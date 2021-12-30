namespace _20211230_IgnitisHomework_V2.Models
{
    public class RegistrationAttribute : Entity
    {
        public int RegistrationId { get; set; }
        public Registration Registration { get; set; }
        public int SelectedOptionId { get; set; }
        public int AttributeId { get; set; }
        public Attribute Attribute { get; set; }   
    }
}
