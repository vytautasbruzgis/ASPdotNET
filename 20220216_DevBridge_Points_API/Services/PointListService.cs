using _20220216_DevBridge_Points_API.Dtos;
using _20220216_DevBridge_Points_API.Models;
using _20220216_DevBridge_Points_API.Repositories;
using _20220216_DevBridge_Points_API.Validators;
using AutoMapper;
using FluentValidation;
using System;
using System.Threading.Tasks;

namespace _20220216_DevBridge_Points_API.Services
{
    public class PointListService : ServiceNamedBase<PointList, PointListRepository, PointListDto>
    {
        private PointService _pointService;
        public PointListService(PointListRepository repository, IMapper mapper, PointService pointService) : base(repository, mapper)
        { 
            _pointService = pointService;
        }

        public async Task<PointListDto> CreateAsync(PointListCreateDto pointListCreateDto)
        {
            //validate
            PointListValidator validator = new PointListValidator();
            validator.ValidateAndThrow(pointListCreateDto);
            return await base.CreateAsync(_mapper.Map<PointListDto>(pointListCreateDto));
        }
        public new async Task<PointListDto> GetAsync(int id)
        {
            var pointList = await _repo.GetIncludedAsync(id);
            var pointListDto = _mapper.Map<PointListDto>(pointList);
            return pointListDto;
        }
        public new async Task DeleteAsync(int id)
        {
            await _pointService.DeleteByPointListId(id);
            await base.DeleteAsync(id);
        }

    }
}
