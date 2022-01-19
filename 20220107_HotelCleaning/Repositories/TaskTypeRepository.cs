using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Repositories
{
    public class TaskTypeRepository: RepositoryBase<TaskType>
    {
        public TaskTypeRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
