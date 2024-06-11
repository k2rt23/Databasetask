using System.Collections.Generic;

public class Job
{
    public int JobID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Salary { get; set; }
    public int EmployeeID { get; set; }
    public virtual Employee Employee { get; set; }
}

