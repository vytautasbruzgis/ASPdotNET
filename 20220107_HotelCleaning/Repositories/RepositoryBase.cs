using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Repositories
{
    public abstract class RepositoryBase<T> where T : Entity
    {
        protected DataContext _dataContext;
        protected DbSet<T> _dbSet;
        public RepositoryBase(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dbSet = _dataContext.Set<T>();
        }
        public T Get(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList(); 
        }
        public List<T> GetAllNotDeleted()
        {
            return _dbSet.Where(x => x.IsDeleted == false).ToList();
        }
    }
}
