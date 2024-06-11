using System;

public class Request
{
    public int RequestId { get; set; }
    public int EmployeeId { get; set; }
    public string RequestType { get; set; }
    public DateTime RequestDate { get; set; }
    public string Status { get; set; }

    public virtual Employee Employee { get; set; }
}
