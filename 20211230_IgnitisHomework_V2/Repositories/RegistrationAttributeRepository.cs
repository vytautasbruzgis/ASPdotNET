using _20211230_IgnitisHomework_V2.Data;
using _20211230_IgnitisHomework_V2.Models;
using _20211230_IgnitisHomeWork_V2.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20211230_IgnitisHomework_V2.Repositories
{
    public class RegistrationAttributeRepository :RepositoryBase<RegistrationAttribute>
    {
        public RegistrationAttributeRepository(DataContext dataContext) : base(dataContext)
        {

        }
        public List<RegistrationAttribute> GetByRegistrationId(int id)
        {
            return _dbSet.Where(x => x.RegistrationId == id).Include(x => x.Attribute).ThenInclude(x => x.Options).ToList();
        }
    }
}
