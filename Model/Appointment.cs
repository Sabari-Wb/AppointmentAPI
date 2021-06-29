using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleAppointment.Model
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public string SpecializationReqired { get; set; }
        public string DoctorName { get; set; }
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        [DataType(DataType.Time)]
        public DateTime AppointmentTimeFROM { get; set; }
        [DataType(DataType.Time)]
        public DateTime AppointmentTimeTO { get; set; }

        public Appointment()
        {

        }

        public Appointment(int appointid, int patientid, string specialization, string doctorname, DateTime Appointdate, DateTime Appointtimefrom, DateTime Appointtimeto)
        {
            AppointmentID = appointid;
            PatientID = patientid;
            SpecializationReqired = specialization;
            DoctorName = doctorname;
            AppointmentDate = Appointdate;
            AppointmentTimeFROM = Appointtimefrom;
            AppointmentTimeTO = Appointtimeto;



        }
    }
}
