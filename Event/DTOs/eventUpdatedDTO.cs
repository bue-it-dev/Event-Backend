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

        public DateTime? UpdateAt { get; set; }

        public DateTime? EndDateTime { get; set; }

        public DateTime? StartDateTime { get; set; }

        public string? OrganizerName { get; set; }

        public int? OrganizerMobile { get; set; }

        public int? OrganizerExtention { get; set; }

        public string? ApprovingDeptName { get; set; }

        public int? DeptId { get; set; }

        public int? IsOthers { get; set; }

        public int? IsStaffStudents { get; set; }

        public int? IsChairBoardPrisidentVcb { get; set; }

        public IFormFile? LedOfTheUniversityOrganizerFile { get; set; }

        public IFormFile? OfficeOfPresedentFile { get; set; }

        public IFormFile? VisitAgendaFile { get; set; }
    }
}
