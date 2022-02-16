using _20220216_DevBridge_Points_API.Data;
using _20220216_DevBridge_Points_API.Models;

namespace _20220216_DevBridge_Points_API.Repositories
{
    public class PointListRepository : RepositoryBase<PointList>
    {
        public PointListRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
