namespace _20210118_School_API.Dtos
{
    public class StudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int SchoolId { get; set; }
        public SchoolDto School { get; set; }
    }
}
