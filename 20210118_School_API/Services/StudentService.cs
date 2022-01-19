using _20210118_School_API.Models;
using _20210118_School_API.Repositories;
using _20220118_School_API.Data;

namespace _20210118_School_API.Services
{
    public class StudentService : ServiceBase<Student, StudentRepository>
    {
        private SchoolService _school;
        public StudentService(StudentRepository studentRepository) : base(studentRepository)
        {
        }
        new public void Delete(int id)
        {
            base.Delete(id);
        }
    }
}
