using System.Collections.Generic;

namespace _20220216_DevBridge_Points_API.Models
{
    public class Point : Entity
    {
        public int? PointListId { get; set; }
        public PointList? PointList { get; set; }
        public int X_Coordinate { get; set; }
        public int Y_Coordinate { get; set; }
        public List<Square> Squares { get; set; }
    }
}
