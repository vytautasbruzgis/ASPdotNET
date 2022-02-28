using _20220216_DevBridge_Points_API.Data;
using _20220216_DevBridge_Points_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace _20220216_DevBridge_Points_API.Repositories
{
    public class PointListRepository : NamedRepositoryBase<PointList>
    {
        public PointListRepository(DataContext dataContext) : base(dataContext)
        {
        }
        public async Task<PointList> GetIncludedAsync(int id)
        {
            return await _dbSet.Include(x => x.Points.Where( y => y.IsDeleted == false)).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
