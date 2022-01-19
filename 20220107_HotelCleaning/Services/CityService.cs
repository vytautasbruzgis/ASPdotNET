using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;
using System.Collections.Generic;

namespace _20220107_HotelCleaning.Services
{
    public class CityService
    {
        private CityRepository _cityRepo;

        public CityService(CityRepository cityRepository)
        {
            _cityRepo = cityRepository;
        }
        public void Create(City city)
        {
            _cityRepo.Add(city);
        }
        public City Get(int id)
        {
            return _cityRepo.Get(id);
        }
        public List<City> GetAllNotDeleted()
        {
            return _cityRepo.GetAllNotDeleted();
        }
    }
}
