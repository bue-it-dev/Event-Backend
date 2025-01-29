using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpEmployee
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string? Image { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string? WorkEmail { get; set; }

    public string? OtherEmail { get; set; }

    public string? HomePhone { get; set; }

    public string? MobilePhone { get; set; }

    public string? WorkPhone { get; set; }

    public string? Religion { get; set; }

    public string? IdNumber { get; set; }

    public string? Nationality { get; set; }

    public string? MaritalStatus { get; set; }

    public string? AddCity { get; set; }

    public string? AddStreet { get; set; }

    public string? AddCountry { get; set; }

    public string? AddStateProvince { get; set; }

    public string? AddZipPostalCode { get; set; }

    public string? DrivingLicenceNumber { get; set; }

    public DateOnly? DrivingLicenceExpiryDate { get; set; }

    public DateOnly JobJointDate { get; set; }

    public DateOnly? ContractStartDate { get; set; }

    public DateOnly? ContractEndDate { get; set; }

    public string? ContractFile { get; set; }

    public int? JobId { get; set; }

    public int? DirectManagerId { get; set; }

    public float? SalaryAmount { get; set; }

    public string? BankAccountNumber { get; set; }

    public int? EmpTypeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? StatusId { get; set; }

    public int? OvertimeId { get; set; }

    public int? CardNumber { get; set; }

    public bool IsManager { get; set; }

    public sbyte HasAttendance { get; set; }

    public sbyte Academic { get; set; }

    public int? PolAttRestriction { get; set; }

    public int ViolationCounter { get; set; }

    public int ConsecutiveViolationCounter { get; set; }

    public bool IsConsecutive { get; set; }

    public int? Category { get; set; }

    public DateOnly? ResignationDate { get; set; }

    public virtual ICollection<BueAttAttendance2> BueAttAttendance2s { get; set; } = new List<BueAttAttendance2>();

    public virtual ICollection<Buecarinfouser> Buecarinfousers { get; set; } = new List<Buecarinfouser>();

    public virtual ICollection<Pendingbuecarinfo> Pendingbuecarinfos { get; set; } = new List<Pendingbuecarinfo>();
}
