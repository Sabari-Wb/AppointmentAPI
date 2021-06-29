using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleAppointment.Model;
using ScheduleAppointment.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleAppointment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentProvider _appointmentprovider;

        public AppointmentsController(IAppointmentProvider appointmentprovider)
        {
            _appointmentprovider = appointmentprovider;
        }

        // GET: api/Appointment
        [HttpGet("Appointmentsdetail")]
        public ActionResult<List<Appointment>> GetAppointmentdetails()
        {
            return _appointmentprovider.GetAppointmentdetails();
        }
        //public IActionResult GetAppointmentDetails()                              // for unit test
        //{
        //    return Ok(_appointmentprovider.GetAppointmentdetails());
        //}

        // GET: api/Appointments/5
        [HttpGet("{id}")]
        public ActionResult<Appointment> GetAppointmentdetailbyID(int id)
        {
            return _appointmentprovider.GetAppointmentdetailById(id);


        }
        //public IActionResult GetAppointmentdetailbyID(int id)                          // for unit test
        //{
        //    return Ok(_appointmentprovider.GetAppointmentdetailById(id));
        //}

        // PUT: api/Appointments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutAppointment(int id, Appointment p)
        {


            try
            {
                _appointmentprovider.UpdateAppointmentdetail(id, p);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_appointmentprovider.AppointmentdetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Appointments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Appointment> PostAppointment(Appointment p)
        {
            _appointmentprovider.AddNewAppointment(p);

            return CreatedAtAction("GetAppointmentdetails", new { id = p.AppointmentID }, p);
        }
        //public IActionResult PostAppointment(Appointment p)                        //unittest
        //{
        //    _appointmentprovider.AddNewAppointment(p);

        //    return CreatedAtAction("GetAppointmentdetails", new { id = p.AppointmentID }, p);
        //}

        // DELETE: api/Appointments/5
        [HttpDelete("{id}")]
        public IActionResult DeleteAppointment(int id)
        {
            _appointmentprovider.DeleteAppointmentdetail(id);
            return NoContent();
        }

    }
}
