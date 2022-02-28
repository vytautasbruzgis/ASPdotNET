using _20220216_DevBridge_Points_API.Data;
using _20220216_DevBridge_Points_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20220216_DevBridge_Points_API.Repositories
{
    public class PointRepository : RepositoryBase<Point>
    {
        public PointRepository(DataContext dataContext) : base(dataContext)
        {
        }
        public async Task<List<Point>> GetPointsByPointListIdAsync(int pointListId)
        {
            return await _dbSet.Where(x => x.PointListId == pointListId && x.IsDeleted == false).ToListAsync();
        }
    }
}
