using System.Collections.Generic;

namespace _20220216_DevBridge_Points_API.Models
{
    public class PointList: NamedEntity
    {
        public List<Point> Points { get; set; }
        public List<Square> Squares { get; set; }
    }
}
