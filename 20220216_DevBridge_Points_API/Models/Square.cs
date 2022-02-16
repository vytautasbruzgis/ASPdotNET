using System.Collections.Generic;

namespace _20220216_DevBridge_Points_API.Models
{
    public class Square: Entity
    {
        public List<Point> Points { get; set; }
        public int PointListId { get; set; }
        public PointList PointList { get; set; }
    }
}
