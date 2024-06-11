using System;

public class AccessPermission
{
    public int AccessPermissionId { get; set; }
    public string PermissionName { get; set; }
    public string Description { get; set; }
    public DateTime GrantedDate { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}


