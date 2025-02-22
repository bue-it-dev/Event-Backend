namespace Event.DTOs
{
    public class AccommodationDTO
    {
        public int? RoomTypeId { get; set; }

        public int? EventId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        public int? NumOfRooms { get; set; }


    }
}
