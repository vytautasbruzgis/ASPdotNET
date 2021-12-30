using _20211230_IgnitisHomework_V2.Repositories;

namespace _20211230_IgnitisHomework_V2.Services
{
    public class AttributeService
    {
        private AttributeRepository _attrRepo;
        public AttributeService(AttributeRepository attrRepo)
        {
            _attrRepo = attrRepo;
        }
    }
}
