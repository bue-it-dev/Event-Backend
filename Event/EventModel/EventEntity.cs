using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class EventEntity
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

    public int? IsOthers { get; set; }

    public int? IsStaffStudents { get; set; }

    public int? IsChairBoardPrisidentVcb { get; set; }

    public DateTime? DecisionAt { get; set; }

    public string? LedOfTheUniversityOrganizerFile { get; set; }

    public string? OfficeOfPresedentFile { get; set; }

    public string? VisitAgendaFile { get; set; }

    public int? EmpId { get; set; }

    public DateTime? ConfirmedAt { get; set; }

    public string? OrganizerEmail { get; set; }

    public int? IsVip { get; set; }

    public int? NatureOfEventId { get; set; }

    public string? OrganizerPosition { get; set; }

    public virtual ICollection<Accommodation> Accommodations { get; set; } = new List<Accommodation>();

    public virtual ICollection<BuildingVenue> BuildingVenues { get; set; } = new List<BuildingVenue>();

    public virtual ICollection<EventApproval> EventApprovals { get; set; } = new List<EventApproval>();

    public virtual ICollection<ItcomponentEvent> ItcomponentEvents { get; set; } = new List<ItcomponentEvent>();

    public virtual NatureOfEventLookup? NatureOfEvent { get; set; }

    public virtual ICollection<Passport> Passports { get; set; } = new List<Passport>();

    public virtual ICollection<Transportation> Transportations { get; set; } = new List<Transportation>();
}
