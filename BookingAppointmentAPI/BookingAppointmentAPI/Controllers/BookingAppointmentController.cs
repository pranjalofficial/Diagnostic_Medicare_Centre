using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingAppointmentAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingAppointmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingAppointmentController : ControllerBase
    {
        Medicare_SystemContext msc = new Medicare_SystemContext();
        // GET: api/BookingAppointment
        [HttpGet]
        public IEnumerable<partialMedicalServiceList> Get()
        {
            List<TblMedicare> medi = msc.TblMedicare.FromSql("getAllMedicareServices").ToList();

            List<partialMedicalServiceList> temp = new List<partialMedicalServiceList>();
            foreach (TblMedicare tcm in medi)
            {
                partialMedicalServiceList partial = new partialMedicalServiceList();
                partial.Sno = tcm.SNo;
                partial.MdMedicareId = tcm.MdMedicareId;
                partial.MdMedicareService = tcm.MdMedicareService;
                temp.Add(partial);
            }
            return temp;
        }


        // GET: api/BookingAppointment/5
        [HttpGet("{id}")]
        
        public IEnumerable<CorrespondingDoctorList> Get(string id)
        {
            List<TblDoctor> doc = msc.TblDoctor.FromSql("exec getCorrespondingDoctors '" + id + "'").ToList();

            List<CorrespondingDoctorList> cospList = new List<CorrespondingDoctorList>();
            foreach(TblDoctor temp in doc)
            {
                CorrespondingDoctorList cdl = new CorrespondingDoctorList();
                cdl.SNo = temp.SNo;
                cdl.DrUserId = temp.DrUserId;
                cdl.DrFirstName = temp.DrFirstName;
                cdl.DrLastName = temp.DrLastName;
                cospList.Add(cdl);
            }

            return cospList;
        }

        // POST: api/BookingAppointment
        [HttpPost]
        public void Post([FromBody] TblAppointment appointment)
        {
            msc.Database.ExecuteSqlCommand("exec bookingAppointment '" + appointment.ApDrUserId + "','" + appointment.ApMdMedicareServiceId + "','" + appointment.ApPtUserId + "','" + appointment.ApDate + "','" + appointment.ApTime + "'");
        }

        // PUT: api/BookingAppointment/5
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
