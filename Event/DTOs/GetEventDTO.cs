namespace Event.DTOs
{
    public class GetEventDTO
    {
        public int EventId { get; set; }

        public int? ApprovingDepTypeId { get; set; }

        public string EventTitle { get; set; } = null!;

        public int? NomParticipants { get; set; }

        public DateTime EventStartDate { get; set; }

        public DateTime? EventEndDate { get; set; }

        public int HasIt { get; set; }

        public int HasAccomdation { get; set; }

        public int HasTransportation { get; set; }

        public string? BudgetlineName { get; set; }

        public string? BudgetCode { get; set; }

        public string? BudgetCostCenter { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public string? OrganizerName { get; set; }

        public int? OrganizerMobile { get; set; }

        public int? OrganizerExtention { get; set; }

        public string? ApprovingDeptName { get; set; }

        public int? DeptId { get; set; }

        public DateTime? DecisionAt { get; set; }
        public string? OrganizerEmail { get; set; }



        public int? EmpId { get; set; }

        public DateTime? ConfirmedAt { get; set; }
        public int Status { get; set; }
        public int isApprove { get; set; }

        public string StatusName { get; set; }
        public string approvalName { get; set; }

    }
}
