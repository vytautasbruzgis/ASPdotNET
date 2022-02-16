using _20220216_DevBridge_Points_API.Dtos;
using _20220216_DevBridge_Points_API.Models;
using _20220216_DevBridge_Points_API.Repositories;
using AutoMapper;
using System.Threading.Tasks;

namespace _20220216_DevBridge_Points_API.Services
{
    public class PointService : ServiceBase<Point, PointRepository, PointDto>
    {
        public PointService(PointRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
        public new async Task<PointDto> CreateAsync (PointCreateDto pointCreateDto)
        {
            //validate
            PointDto newPoint = await base.CreateAsync(_mapper.Map<PointDto>(pointCreateDto));
            return newPoint;
        }
    }
}
