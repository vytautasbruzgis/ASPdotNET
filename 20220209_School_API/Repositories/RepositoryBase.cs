using _20220209_School_API.Models;
using _20220209_School_API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20220209_School_API.Repositories
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
        public async Task<T> GetAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync(); 
        }
        public async Task<List<T>> GetAllNotDeletedAsync()
        {
            return await _dbSet.Where(x => x.IsDeleted == false).ToListAsync();
        }
        public async Task AddAsync(T item)
        {
            item.IsDeleted = false;
            item.LastModified = System.DateTime.Now;
            item.Created = System.DateTime.Now;

            _dbSet.Add(item);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Update(T item)
        {
            item.LastModified = System.DateTime.Now;
            _dbSet.Update(item);
            await _dataContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var item = await _dbSet.FirstOrDefaultAsync(x=> x.Id == id);
            if(item != null)
            {
               await DeleteAsync(item);
            }
        }
        public async Task DeleteAsync(T item)
        {
            item.IsDeleted = true;
            await Update(item);
        }
    }
    public abstract class NamedRepositoryBase<T> : RepositoryBase<T>
        where T : NamedEntity
    {
        public NamedRepositoryBase(DataContext dataContext) : base(dataContext)
        {

        }
        public List<T> GetByName(string itemName)
        {
            List<T> list = new List<T>();
            list = _dbSet.Where(x => x.Name == itemName && x.IsDeleted == false).ToList();
            return list;
        }
    }
}
