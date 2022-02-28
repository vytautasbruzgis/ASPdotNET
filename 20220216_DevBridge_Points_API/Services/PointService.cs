using _20220216_DevBridge_Points_API.Dtos;
using _20220216_DevBridge_Points_API.Models;
using _20220216_DevBridge_Points_API.Repositories;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20220216_DevBridge_Points_API.Services
{
    public class PointService : ServiceBase<Point, PointRepository, PointDto>
    {
        public PointService(PointRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
        public async Task<PointDto> CreateAsync (PointCreateDto pointCreateDto)
        {
            //validate
            var pointDto = _mapper.Map<PointDto>(pointCreateDto);
            PointDto newPoint = await base.CreateAsync(pointDto);
            return newPoint;
        }
        public async Task DeleteByPointListId(int id)
        {
            List<Point> points = await GetByPointListId(id);
            if (points.Any())
            {
                foreach (var point in points)
                {
                    await base.DeleteAsync(point);
                }
            }
        }
        private async Task<List<Point>> GetByPointListId(int id)
        {
            List<Point> points = await _repo.GetPointsByPointListIdAsync(id);
            return points;
        }
    }
}
