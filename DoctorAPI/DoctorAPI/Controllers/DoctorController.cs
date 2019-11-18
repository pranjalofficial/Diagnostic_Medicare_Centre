using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DoctorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        Medicare_SystemContext msc = new Medicare_SystemContext();
        // GET: api/Doctor
        [HttpGet]
        public IEnumerable<TblMedicare> Get()
        {
            return msc.TblMedicare.ToList();
        }

        // GET: api/Doctor/5
        [HttpGet("{id}")]
        public IEnumerable<TblAppointment> Get(string id)
        {
            return msc.TblAppointment.FromSql("exec doctorAppointments '" + id + "'").ToList();
        }

        // POST: api/Doctor
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Doctor/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
