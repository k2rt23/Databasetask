using System;

public class Laenutus
{
    public int LaenutusId { get; set; }
    public int LaenutavadAsjadId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime LaenutusDate { get; set; }
    public DateTime ReturnDate { get; set; }

    public virtual LaenutavadAsjad LaenutavadAsjad { get; set; }
    public virtual Employee Employee { get; set; }
}