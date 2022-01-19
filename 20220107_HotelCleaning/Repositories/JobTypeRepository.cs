using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Repositories
{
    public class JobTypeRepository: RepositoryBase<JobType>
    {
        public JobTypeRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
