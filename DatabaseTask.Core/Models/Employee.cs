

public enum Gender
{
    Male,
    Female,
    Other
}

public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public string ContactAddress { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string SecurityNumber { get; set; }
    public DateTime Birthday { get; set; }
    public int BranchID { get; set; }
    public virtual Branch Branch { get; set; }
    public virtual ICollection<Job> Jobs { get; set; }
    public virtual ICollection<Vacation> Vacations { get; set; }
}
