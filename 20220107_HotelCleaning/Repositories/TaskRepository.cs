using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20220107_HotelCleaning.Repositories
{
    public class TaskRepository: RepositoryBase<HotelTask>
    {
        public TaskRepository(DataContext dataContext) : base(dataContext)
        {

        }
        public HotelTask GetCleaningTaskForRoom(int roomId)
        {
            return _dbSet.FirstOrDefault(x => x.RoomId == roomId && x.TaskTypeId == 1 && x.IsCompleted == false);
        }
    }
}
