using _20220209_School_API.Services;
using _20220209_School_API.Dtos;
using _20220209_School_API.Models;
using _20220209_School_API.Repositories;
using AutoMapper;

namespace _20220209_School_API.Services
{
    public class StudentService : ServiceBase<Student, StudentRepository, StudentDto>
    {
        public StudentService(StudentRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
