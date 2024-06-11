﻿using System;

public class SickDays
{
    public int SickDaysId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }

    public virtual Employee Employee { get; set; }
}

