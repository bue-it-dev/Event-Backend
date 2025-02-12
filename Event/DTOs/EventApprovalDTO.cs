namespace Event.DTOs
{
    public class EventApprovalDTO
    {
        public int? EventId { get; set; }
        public int EmpId { get; set; }
        public int UserTypeId { get; set; }
        public int? IsApprove { get; set; }
    }

}
