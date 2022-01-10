using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _20220107_HotelCleaning.Models.Dtos
{
    public class RoomCreateDto
    {
        public RoomCreateDto(int maxFloor)
        {
            List<int> Floors = new List<int>();
            for (int i = 0; i < maxFloor; i++)
            {
                Floors.Add(i + 1);
            }
        }
        [Required]
        public int HotelId { get; set; }
        
        public List<Hotel> Hotels{ get; set;}
        [Required]
        public int RoomNumber { get; set; }
        [Required] 
        public int FloorNumber { get; set; }
        [Required]
        public string Name { get; set; }
        public List<int> Floors { get; set; }
    }
    public static class RoomDtoMapper
    {
        public static Room MapToRoom (RoomCreateDto roomCreate)
        {
            Room room = new();

            room.Name = roomCreate.Name;
            room.FloorNumber = roomCreate.FloorNumber;
            room.RoomNumber = roomCreate.RoomNumber;
            room.HotelId = (int)roomCreate.HotelId;

            return room;

        }
    }
}
