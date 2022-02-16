using _20220216_DevBridge_Points_API.Data;
using _20220216_DevBridge_Points_API.Models;

namespace _20220216_DevBridge_Points_API.Repositories
{
    public class SquareRepository : RepositoryBase<Square>
    {
        public SquareRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
