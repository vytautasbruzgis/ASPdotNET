using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;
using System.Collections.Generic;

namespace _20220107_HotelCleaning.Services
{
    public class VisitorService
    {
        private VisitorRepository _visitorRepo;

        public VisitorService(VisitorRepository visitorRepository)
        {
            _visitorRepo = visitorRepository;
        }
        public void Create(Visitor visitor)
        {
            _visitorRepo.Add(visitor);
        }
        public Visitor Get(int id)
        {
            return _visitorRepo.Get(id);
        }
        public List<Visitor> GetAllNotDeleted()
        {
            return _visitorRepo.GetAllNotDeleted();
        }
        public List<Visitor> GetAllNotDeletedIncluded()
        {
            return _visitorRepo.GetAllNotDeletedIncluded();
        }
    }
}
