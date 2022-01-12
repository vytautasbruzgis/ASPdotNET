using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;

namespace _20220107_HotelCleaning.Services
{
    public class PersonService
    {
        private PersonRepository _personRepo;

        public PersonService(PersonRepository personRepository)
        {
            _personRepo = personRepository;
        }

        public void Create(Person person)
        {
            _personRepo.Add(person);
        }
    }
}
