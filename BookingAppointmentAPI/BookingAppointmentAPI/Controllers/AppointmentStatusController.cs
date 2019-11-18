using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookingAppointmentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingAppointmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentStatusController : ControllerBase
    {
        Medicare_SystemContext msc = new Medicare_SystemContext();
        // GET: api/AppointmentStatus
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AppointmentStatus/5
        [HttpGet("{id}")]
  
        public IEnumerable<TblAppointment> Get(string id)
        {
            List<TblAppointment> appointment = null;
            try
            {
                appointment = msc.TblAppointment.FromSql("getPendingAppointmentDetails '" + id + "'").ToList();
                return appointment;
            }
            catch(Exception)
            {
                return appointment;
            }
        }

        // POST: api/AppointmentStatus
        [HttpPost]
        
        public void Post([FromBody]string value)
        {
           
        }

        // PUT: api/AppointmentStatus/5
        [HttpPut("{value}")]
        public void Put(string value)
        {
            try
            {
                msc.Database.ExecuteSqlCommand("exec changeAppointmentStatus '" + value + "'");
            }
            catch (Exception)
            {
                Console.WriteLine("Some error occured in the sewrver./t 404 Not Found");
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            try
            {
                msc.Database.ExecuteSqlCommand("deleteDeniedAppointment '"+id+"'");
            }
            catch(Exception)
            {
                Console.WriteLine("404 No");
            }
        }
    }
}
