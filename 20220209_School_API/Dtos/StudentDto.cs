namespace _20220209_School_API.Dtos
{
    public class StudentDto : DtoBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolId { get; set; }
        public string FullName { get; set; }
    }
}
