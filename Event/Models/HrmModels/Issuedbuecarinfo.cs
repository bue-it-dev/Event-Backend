using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class Issuedbuecarinfo
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

    public DateTime CreatedAt { get; set; }
}
