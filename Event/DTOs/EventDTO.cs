using Event.EventModel;
using System.ComponentModel.DataAnnotations;

namespace Event.DTOs
{
    public class EventDTO
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

        public string? OrganizerName { get; set; }

        [RegularExpression(@"^01(0|1|2|5)\d{8}$", ErrorMessage = "Please enter a valid Egyptian phone number.")]
        public string OrganizerMobile { get; set; }

        [RegularExpression(@"^[1-9]{4}$", ErrorMessage = "Extension must be exactly 4 digits, using only numbers 1-9.")]
        public string OrganizerExtention { get; set; }


        public string? ApprovingDeptName { get; set; }

        public int? DeptId { get; set; }

        public int? IsOthers { get; set; }

        public int? IsStaffStudents { get; set; }

        public int? IsChairBoardPrisidentVcb { get; set; }

        public IFormFile? LedOfTheUniversityOrganizerFile { get; set; }

        public IFormFile? OfficeOfPresedentFile { get; set; }

        public IFormFile? VisitAgendaFile { get; set; }



            public List<ItcomponentEventDTO> ItcomponentEvents { get; set; } = new List<ItcomponentEventDTO>();
            public List<TransportationDTO> Transportations { get; set; } = new List<TransportationDTO>();
            public List<AccommodationDTO> Accommodations { get; set; } = new List<AccommodationDTO>();
            public List<BuildingVenuesDTO> BuildingVenues { get; set; } = new List<BuildingVenuesDTO>();
        




    }
}
