﻿namespace vesta_api.Database.Models;

public partial class Appointment
{
    public int Id { get; set; }

    public DateTime Datetime { get; set; }

    public int ClientId { get; set; }

    public int EmployeeId { get; set; }

    public int ServiceId { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
}