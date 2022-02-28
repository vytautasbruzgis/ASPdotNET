namespace _20220216_DevBridge_Points_API.Dtos
{
    public class PointDto : DtoBase
    {
        public int Id { get; set; }
        public int? PointListId { get; set; }
        public int X_Coordinate { get; set; }
        public int Y_Coordinate { get; set; }
    }
}
