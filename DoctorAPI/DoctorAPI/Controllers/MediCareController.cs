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
    public class MediCareController : ControllerBase
    {
        Medicare_SystemContext msc = new Medicare_SystemContext();
        // GET: api/MediCare
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MediCare/5
        [HttpGet("{id}")]
        public TblMedicare Get(string id)
        {
            return msc.TblMedicare.FromSql("medicareById '"+id+"'").Single();
        }

        // POST: api/MediCare
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/MediCare/5
        [HttpPut]
        public void Put([FromBody] TblMedicare medicare)
        {
            msc.TblMedicare.FromSql("updateMedicareService '" + medicare.MdMedicareId + "','" + medicare.MdMedicareService + "','" + medicare.MdServiceDesp + "','" + medicare.MdAmount + "'");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
