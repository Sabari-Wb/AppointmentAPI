using ScheduleAppointment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleAppointment.Repository
{
   public  interface IAppointmentRepo
    {
        public List<Appointment> GetAppointmentdetails();
        public Appointment GetAppointmentdetailById(int id);
        public Appointment AddNewAppointment(Appointment p);
        public void DeleteAppointmentdetail(int id);

        public Appointment UpdateAppointmentdetail(int id, Appointment p);
        public bool AppointmentdetailExists(int id);
    }
}
