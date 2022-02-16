using _20220216_DevBridge_Points_API.Data;
using _20220216_DevBridge_Points_API.Models;

namespace _20220216_DevBridge_Points_API.Repositories
{
    public class PointRepository : RepositoryBase<Point>
    {
        public PointRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
