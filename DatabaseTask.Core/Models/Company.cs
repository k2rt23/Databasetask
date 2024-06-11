using System.Collections.Generic;

public class Company
{
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public virtual ICollection<Branch> Branches { get; set; }
}
