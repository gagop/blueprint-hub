﻿namespace Gakko.Core.Entities;

public class AppointmentStatus
{
    public int IdAppointmentStatus { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}