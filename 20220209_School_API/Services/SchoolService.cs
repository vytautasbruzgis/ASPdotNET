using _20220209_School_API.Repositories;
using _20220209_School_API.Dtos;
using _20220209_School_API.Models;
using AutoMapper;
using System.Threading.Tasks;
using System;

namespace _20220209_School_API.Services
{

    public class SchoolService : ServiceNamedBase<School, SchoolRepository, SchoolDto>
    {
        private StudentService _studentService;
        public SchoolService(SchoolRepository repository, IMapper mapper,
            StudentService studentService) : base(repository, mapper)
        {
            _studentService = studentService;
        }
        public async Task<SchoolDto> CreateAsync(SchoolCreateDto createDto)
        {
            if (IsNameUnique(createDto.Name))
            {
                SchoolDto shopDto = new SchoolDto
                {
                    Name = createDto.Name
                };
                return await base.CreateAsync(shopDto);
            }
            else
            {
                throw new ArgumentException("School name is not unique");
            }
        }
        public async new Task DeleteAsync(int id)
        {
            School school = await _repo.GetIncludedAsync(id);
            if (school.Students.Count > 0)
            {
                foreach (var student in school.Students)
                {
                    await _studentService.DeleteAsync(student.Id);
                }
            }
            await base.DeleteAsync(id);
        }
    }
}
