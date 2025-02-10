using Event.EventModel;

namespace Event.DTOs
{
    public class EventDTO
    {
        public int EventId { get; set; }
        public int? IsAcademic { get; set; }

        public int? ApprovingDepTypeId { get; set; }

        public string EventTitle { get; set; } = null!;

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

        public DateTime? EndDateTime { get; set; }

        public DateTime? StartDateTime { get; set; }

        public string? OrganizerName { get; set; }

        public int? OrganizerMobile { get; set; }

        public int? OrganizerExtention { get; set; }

        public string? ApprovingDeptName { get; set; }

        public int? DeptId { get; set; }
        public string DeptName { get; set; }    

        public virtual ICollection<ItcomponentEventDTO> ItcomponentEvents { get; set; }
        public virtual ICollection<TransportationDTO> Transportations { get; set; } 

        public virtual ICollection<AccommodationDTO> Accommodations { get; set; }
        public virtual ICollection<BuildingVenuesDTO> BuildingVenues { get; set; }



    }
}
