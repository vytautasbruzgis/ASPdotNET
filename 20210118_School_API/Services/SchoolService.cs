using _20210118_School_API.Models;
using _20210118_School_API.Repositories;
using _20220118_School_API.Data;
using System.Collections.Generic;
using System.Linq;

namespace _20210118_School_API.Services
{
    public class SchoolService : ServiceBase<School, SchoolRepository>
    {
        public SchoolService(SchoolRepository schoolRepository) : base(schoolRepository)
        {
        }
    }
}
