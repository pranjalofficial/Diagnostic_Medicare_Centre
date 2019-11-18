using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistrationLoginAPI.Models;

namespace RegistrationLoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        Medicare_SystemContext ms = new Medicare_SystemContext();


        // POST: api/Registration
        [HttpPost]
        public void Post([FromBody] TblPatient patientDetails)
        {
            ms.Database.ExecuteSqlCommand("insertpatientdetails '" + patientDetails.PtFirstName + "','" + patientDetails.PtLastName + "'," + patientDetails.PtAge + ",'" + patientDetails.PtGender + "','" + patientDetails.PtDob + "'," + patientDetails.PtContactNo + "," + patientDetails.PtAltContactNo + ",'" + patientDetails.PtEmail + "','" + patientDetails.PtPassword + "','" + patientDetails.PtAddress1 + "','" + patientDetails.PtAddress2 + "','" + patientDetails.PtCity + "','" + patientDetails.PtState + "'," + patientDetails.PtZipcode);
        }
    }
}
