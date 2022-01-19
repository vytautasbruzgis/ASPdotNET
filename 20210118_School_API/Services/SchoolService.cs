using _20210118_School_API.Models;
using _20210118_School_API.Repositories;
using _20220118_School_API.Data;
using System.Collections.Generic;
using System.Linq;

namespace _20210118_School_API.Services
{
    public class SchoolService : ServiceBase<School, SchoolRepository>
    {
        private readonly StudentService _studentService;
        public SchoolService(SchoolRepository schoolRepository, StudentService studentService) : base(schoolRepository)
        {
            _studentService = studentService;
        }
        /* review */
        /* ar yra koks kitoks būdas, jeigu nori base metodą tiesiog praplėsti? */
        public new void Delete(int id) 
        {
            var school = _repo.Get(id);
            if (school.Students.Any())
            {
                foreach (Student student in school.Students)
                {
                    _studentService.Delete(student.Id);
                }
            }
            base.Delete(id);
        }
    }
}
