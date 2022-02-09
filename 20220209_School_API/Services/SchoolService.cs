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
        public SchoolService(SchoolRepository repository, IMapper mapper) : base(repository, mapper)
        {
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
    }
}
