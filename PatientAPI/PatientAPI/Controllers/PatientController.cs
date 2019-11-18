using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientAPI.Models;

namespace PatientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        Medicare_SystemContext msc = new Medicare_SystemContext();
        // GET: api/Patient
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Patient/5
        [HttpGet("{id}")]
        public IEnumerable<TblMedicalTestHistory> Get(string id)
        {
            return msc.TblMedicalTestHistory.FromSql("gettestresult '" +id+"'").ToList();
        }

        // POST: api/Patient
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Patient/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
