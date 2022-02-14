using _20220209_School_API.Models;
using _20220209_School_API.Repositories;
using _20220209_School_API.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20220209_School_API.Services
{
    public abstract class ServiceBase<T, E, D> 
        where T : Entity
        where E : RepositoryBase<T>
        where D : DtoBase
    {
        protected E _repo;
        protected IMapper _mapper;

        public ServiceBase(E repository, IMapper mapper)
        {
            _repo = repository;
            _mapper = mapper;
        }
        public async Task<D> GetAsync(int id)
        {
            T item = await _repo.GetAsync(id);
            if (item == null)
            {
                throw new ArgumentException($"Item with id = {id} does not exist");
            }
            D mappedItem = _mapper.Map<D>(item);
            return mappedItem; 
        }

        public async Task<List<D>> GetAllAsync()
        {
            List<T> list = await _repo.GetAllNotDeletedAsync();
            List<D> mappedList = _mapper.Map<List<D>>(list);
            return mappedList;
        }
        public async Task<D> CreateAsync(D itemDto)
        {
            try
            {
                T item = _mapper.Map<T>(itemDto);
                await _repo.AddAsync(item);
                return _mapper.Map<D>(item);
            } 
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            
        }
        public async Task DeleteAsync(int id)
        {
            var item = await _repo.GetAsync(id);
            if (item == null)
            {
                throw new ArgumentException($"There is no item with id {id}");
            }
            if (item.IsDeleted == true)
            {
                throw new ArgumentException($"Item with id {id} is already deleted");
            }
            await _repo.DeleteAsync(id);
        }
        public async Task DeleteAsync(T item)
        {
            await _repo.DeleteAsync(item);
        }
        public async Task Update(T item)
        {
            await _repo.Update(item);
        }
    }
    public abstract class ServiceNamedBase<T, E, D> : ServiceBase <T, E, D>
        where T : NamedEntity
        where E : NamedRepositoryBase<T>
        where D : DtoBase
    {
        public ServiceNamedBase(E repository, IMapper mapper): base(repository, mapper)
        {

        }
        public bool IsNameUnique(string itemName)
        {
            if (_repo.GetByName(itemName).Any())
            {
                return false;
            }
            return true;
        }
    }
}
