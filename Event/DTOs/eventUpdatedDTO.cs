using Microsoft.AspNetCore.Mvc;

namespace Event.DTOs
{
    public class eventUpdatedDTO
    {
        public int? ApprovingDepTypeId { get; set; }

        public string EventTitle { get; set; } = null!;

        public int? NomParticipants { get; set; }

        public DateTime EventStartDate { get; set; }

        public DateTime? EventEndDate { get; set; }

        public int HasIt { get; set; }

        public int HasAccomdation { get; set; }

        public int HasTransportation { get; set; }

        public string? OrganizerName { get; set; }

        public int? OrganizerMobile { get; set; }

        public int? OrganizerExtention { get; set; }

        public string? ApprovingDeptName { get; set; }

        public int? DeptId { get; set; }

        public int? IsOthers { get; set; }

        public int? IsStaffStudents { get; set; }

        public int? IsChairBoardPrisidentVcb { get; set; }

        public string? OrganizerEmail { get; set; }

        public int? NatureOfEventId { get; set; }

        public string? OrganizerPosition { get; set; }



        public List<ItcomponentEventDTO> ItcomponentEvents { get; set; } = new List<ItcomponentEventDTO>();
        public List<TransportationDTO> Transportations { get; set; } = new List<TransportationDTO>();

        public List<AccommodationDTO> Accommodations { get; set; } = new List<AccommodationDTO>();

        public List<BuildingVenuesDTO> BuildingVenues { get; set; } = new();

    }
}
