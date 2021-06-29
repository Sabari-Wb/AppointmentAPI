using ScheduleAppointment.Model;
using ScheduleAppointment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleAppointment.Provider
{
    public class AppointmentProvider:IAppointmentProvider
    {
        private readonly IAppointmentRepo _appointmentrepo;


        public AppointmentProvider(IAppointmentRepo appointmentrepo)
        {

            _appointmentrepo = appointmentrepo;
        }
        public Appointment AddNewAppointment(Appointment p)
        {
            return _appointmentrepo.AddNewAppointment(p);
        }

        public void DeleteAppointmentdetail(int id)
        {
            _appointmentrepo.DeleteAppointmentdetail(id);
        }

        public bool AppointmentdetailExists(int id)
        {
            return _appointmentrepo.AppointmentdetailExists(id);
        }

        public Appointment GetAppointmentdetailById(int id)
        {
            return _appointmentrepo.GetAppointmentdetailById(id);
        }

        public List<Appointment> GetAppointmentdetails()
        {
            return _appointmentrepo.GetAppointmentdetails();
        }

        public Appointment UpdateAppointmentdetail(int id, Appointment p)
        {
            return _appointmentrepo.UpdateAppointmentdetail(id, p);
        }

    }
}
