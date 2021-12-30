using _20211230_IgnitisHomework_V2.Repositories;

namespace _20211230_IgnitisHomework_V2.Services
{
    public class AttributeOptionService
    {
        private AttributeOptionRepository _attrOptionRepo;
        public AttributeOptionService(AttributeOptionRepository attrOptionRepo)
        {
            _attrOptionRepo = attrOptionRepo;
        }
    }
}
