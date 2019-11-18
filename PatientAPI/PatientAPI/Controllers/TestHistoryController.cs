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
    public class TestHistoryController : ControllerBase
    {
        Medicare_SystemContext msc = new Medicare_SystemContext();
        // GET: api/TestHistory
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TestHistory/5
        [HttpGet("{id}", Name = "Get")]
        public TblMedicalTestHistory Get(string id)
        {
            TblMedicalTestHistory test = null;
            try
            {
                test = msc.TblMedicalTestHistory.FromSql("getTestHistoryPatient '" + id + "'").Single();
                return test;
            }
            catch(Exception)
            {
                Console.WriteLine("There is no test history");
                return test;
            }
            
        }

        // POST: api/TestHistory
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TestHistory/5
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
