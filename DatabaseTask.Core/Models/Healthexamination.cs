using System;

public class HealthExamination
{
    public int HealthExaminationId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime ExaminationDate { get; set; }
    public string ExaminationType { get; set; }
    public string Results { get; set; }

    public virtual Employee Employee { get; set; }
}
