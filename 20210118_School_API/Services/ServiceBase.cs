using _20210118_School_API.Models;
using _20210118_School_API.Repositories;
using System;
using System.Collections.Generic;

namespace _20210118_School_API.Services
{
    public abstract class ServiceBase<T, E> 
        where T : Entity
        where E : RepositoryBase<T>
    {
        protected E _repo;

        public ServiceBase(E repository)
        {
            _repo = repository;
        }
        public T Get(int id)
        {
            return _repo.Get(id);
        }
        public List<T> GetAll()
        {
            return _repo.GetAllNotDeleted();
        }
        public void Create(T item)
        {
            _repo.Add(item);
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
}
