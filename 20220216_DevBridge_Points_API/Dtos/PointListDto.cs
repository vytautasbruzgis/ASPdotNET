using System.Collections.Generic;

namespace _20220216_DevBridge_Points_API.Dtos
{
    public class PointListDto : DtoBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PointDto> Points { get; set; }
    }
}
