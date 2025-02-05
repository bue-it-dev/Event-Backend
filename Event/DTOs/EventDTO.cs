namespace Event.DTOs
{
    public class EventDTO
    {
        public int? IsAcademic { get; set; }

        public int? ApprovingDepTypeId { get; set; }

        public string EventTitle { get; set; } = null!;

        public string? ApprovingDepName { get; set; }

        public int? NomParticipants { get; set; }

        public DateTime EventStartDate { get; set; }

        public DateTime? EventEndDate { get; set; }

        public int HasIt { get; set; }

        public int HasAccomdation { get; set; }

        public int HasTransportation { get; set; }

        public int BudgetlineType { get; set; }

        public string BudgetlineName { get; set; } = null!;

        public string? BudgetCode { get; set; }

        public string? BudgetCostCenter { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public string? OrganizerName { get; set; }

        public int? OrganizerMobile { get; set; }

        public int? OrganizerExtention { get; set; }
    }
}
