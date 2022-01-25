using _20210118_School_API.Repositories;
using _20210121_Shop_API.Models;
using _20220121_Shop_API.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _20210118_School_API.Services
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
        public D Get(int id)
        {
            T item = _repo.Get(id);
            if (item == null)
            {
                throw new ArgumentException($"Item with id = {id} does not exist");
            }
            D mappedItem = _mapper.Map<D>(item);
            return mappedItem; 
        }

        public List<D> GetAll()
        {
            List<T> list = _repo.GetAllNotDeleted();
            if (list == null)
            {
                throw new ArgumentException("There is no items in list");
            }
            List<D> mappedList = _mapper.Map<List<D>>(list);
            return mappedList;
        }
        public int Create(D itemDto)
        {
            try
            {
                T item = _mapper.Map<T>(itemDto);
                _repo.Add(item);
                return item.Id;
            } 
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            
        }
        public void Delete(int id)
        {
            var item = _repo.Get(id);
            if (item == null)
            {
                throw new ArgumentException("1");
            }
            if (item.IsDeleted == true)
            {
                throw new ArgumentException("2");
            }
            _repo.Delete(id);
        }
        public void Delete(T item)
        {
            _repo.Delete(item);
        }
        public void Update(T item)
        {
            _repo.Update(item);
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
