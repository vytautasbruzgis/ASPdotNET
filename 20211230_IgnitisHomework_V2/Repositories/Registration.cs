﻿using _20211230_IgnitisHomework_V2.Data;
using _20211230_IgnitisHomework_V2.Models;
using _20211230_IgnitisHomeWork_V2.Repositories;

namespace _20211230_IgnitisHomework_V2.Repositories
{
    public class RegistrationRepository :RepositoryBase<Registration>
    {
        public RegistrationRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
