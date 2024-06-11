using System;

public class Vacation
{
    public int VacationID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Type { get; set; }  // Näiteks: "Annual Leave", "Sick Leave", jne.
    public int EmployeeID { get; set; }
    public virtual Employee Employee { get; set; }
}

