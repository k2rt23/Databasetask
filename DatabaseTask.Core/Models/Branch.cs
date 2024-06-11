using System.Collections.Generic;

public class Branch
{
    public int BranchID { get; set; }
    public string BranchName { get; set; }
    public string Location { get; set; }
    public virtual ICollection<Employee> Employees { get; set; }
}
