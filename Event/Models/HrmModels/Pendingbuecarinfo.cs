using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class Pendingbuecarinfo
{
    public int CarId { get; set; }

    public int EmployeeId { get; set; }

    public string BrandName { get; set; } = null!;

    public string? CarModel { get; set; }

    public int? ModelYear { get; set; }

    public string CarColor { get; set; } = null!;

    public int CarLicenseNumber { get; set; }

    public string CarLicenseArabicLetter { get; set; } = null!;

    public DateTime CarLicenseEndDate { get; set; }

    public string? CarLicenseFrontPhotoPath { get; set; }

    public string? CarLicenseBackPhotoPath { get; set; }

    public int Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ApprovedAt { get; set; }

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? SecondaryPhone { get; set; }

    public int? BadgeNumber { get; set; }

    public string? ReceivingLocation { get; set; }

    public string? ApprovedBy { get; set; }

    public string? RejectedBy { get; set; }

    public int? Hasbadge { get; set; }

    public int? IsBueAsset { get; set; }

    public string? BueOwner { get; set; }

    public int? IsMigrated { get; set; }

    public virtual BueEmpEmployee Employee { get; set; } = null!;
}
