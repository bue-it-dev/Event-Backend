using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpEmployeeTmp
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string? FnameArabic { get; set; }

    public string? MnameArabic { get; set; }

    public string? LnameArabic { get; set; }

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

    public DateOnly? IdExpiryDate { get; set; }

    public string? Nationality { get; set; }

    public string? MaritalStatus { get; set; }

    public string? MilitaryService { get; set; }

    public string? AddCity { get; set; }

    public string? AddStreet { get; set; }

    public string? AddCountry { get; set; }

    public string? AddStateProvince { get; set; }

    public int? AddZipPostalCode { get; set; }

    public string? AddCity2 { get; set; }

    public string? AddStreet2 { get; set; }

    public string? AddCountry2 { get; set; }

    public string? AddStateProvince2 { get; set; }

    public int? AddZipPostalCode2 { get; set; }

    public string? DrivingLicenceNumber { get; set; }

    public DateOnly? DrivingLicenceExpiryDate { get; set; }

    public DateOnly JobJointDate { get; set; }

    public DateOnly? ContractStartDate { get; set; }

    public DateOnly? ContractEndDate { get; set; }

    public string? ContractFile { get; set; }

    public int? JobId { get; set; }

    public string? BankAccountNumber { get; set; }

    public int? EmpTypeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? StatusId { get; set; }

    public int? CardNumber { get; set; }

    public string? Cv { get; set; }
}
