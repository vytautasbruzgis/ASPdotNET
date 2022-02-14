namespace _20220209_School_API.Dtos
{
    public class StudentCreateDto : DtoBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolId { get; set; }
    }
}
