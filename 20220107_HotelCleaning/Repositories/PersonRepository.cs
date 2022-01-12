using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Repositories
{
    public class PersonRepository: RepositoryBase<Person>
    {
        public PersonRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
