using Microsoft.EntityFrameworkCore;
using ScheduleAppointment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleAppointment.Data
{
    public class AppointmentContext:DbContext
    {
        public AppointmentContext(DbContextOptions<AppointmentContext> options)
           : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
