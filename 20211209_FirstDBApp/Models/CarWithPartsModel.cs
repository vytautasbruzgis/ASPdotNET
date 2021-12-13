using System.Collections.Generic;

namespace _20211209_FirstDBApp.Models
{
    public class CarWithPartsModel
    {
        public CarModel Car { get; set; }
        public List<CarPartModel> Parts { get; set; }

    }
}
