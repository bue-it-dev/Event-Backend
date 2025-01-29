using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class EmpTrainingCourse
{
    public uint Id { get; set; }

    public int EmpId { get; set; }

    public string CourseName { get; set; } = null!;

    public string CoursePlace { get; set; } = null!;

    public DateOnly CourseStartDate { get; set; }

    public DateOnly CourseEndDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
