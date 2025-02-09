namespace Event.DTOs
{
    public class TransportationDTO
    {
        public int? TransportationTypeId { get; set; }

        public int? EventId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
