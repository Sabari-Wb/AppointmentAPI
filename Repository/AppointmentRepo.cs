using Microsoft.EntityFrameworkCore;
using ScheduleAppointment.Data;
using ScheduleAppointment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleAppointment.Repository
{
    public class AppointmentRepo:IAppointmentRepo
    {

        private readonly AppointmentContext _appointmentcontext;
        public AppointmentRepo(AppointmentContext appointmentcontext)
        {
            _appointmentcontext = appointmentcontext;
        }
        public Appointment AddNewAppointment(Appointment p)
        {
            _appointmentcontext.Appointments.Add(p);
            _appointmentcontext.SaveChanges();
            return p;
        }

        public void DeleteAppointmentdetail(int id)
        {
            Appointment p = _appointmentcontext.Appointments.Find(id);
            _appointmentcontext.Appointments.Remove(p);
            _appointmentcontext.SaveChanges();
        }

        public bool AppointmentdetailExists(int id)
        {
            return _appointmentcontext.Appointments.Any(e => e.AppointmentID == id);
        }


        public Appointment GetAppointmentdetailById(int id)
        {
            return _appointmentcontext.Appointments.Find(id);

        }

        public List<Appointment> GetAppointmentdetails()
        {
            return _appointmentcontext.Appointments.ToList();
        }

        public Appointment UpdateAppointmentdetail(int id, Appointment p)
        {
            _appointmentcontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _appointmentcontext.Entry(p).State = EntityState.Modified;
            _appointmentcontext.SaveChanges();
            return p;
        }
    }
}
