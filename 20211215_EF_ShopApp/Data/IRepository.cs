using System.Collections.Generic;

namespace _20211215_EF_ShopApp.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Remove(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllNotDeleted();
        //public Find();
    }

    //public interface IShopRepository : IRepository
    //{

    //}

    //public class Repository: IRepository
    //{
    //    private readonly IRepository _repository;
    //}

    //public class ShopRepository : IShopRepository
    //{

    //}
}
