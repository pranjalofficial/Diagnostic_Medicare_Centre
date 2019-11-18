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
    public class DoctorLoginController : ControllerBase
    {
        Medicare_SystemContext msc = new Medicare_SystemContext();

        // POST: api/DoctorLogin
        [HttpPost]
        public DoctorLogin Post([FromBody] TblDoctor drLogin)
        {

            TblDoctor doctor = msc.TblDoctor.FromSql("doctorauthentication '" + drLogin.DrUserId + "','" + drLogin.DrPassword + "'").SingleOrDefault();

            if (doctor != null)
            {

                DoctorLogin drdetailsFetch = new DoctorLogin();
                drdetailsFetch.DrUserId = doctor.DrUserId;
                drdetailsFetch.DrFirstName = doctor.DrFirstName;
                drdetailsFetch.DrLastName = doctor.DrLastName;
                drdetailsFetch.SNo = doctor.SNo;
                drdetailsFetch.DrMdMedicareServiceId = doctor.DrMdMedicareServiceId;


                return drdetailsFetch;
            }
            else
            {
                DoctorLogin drdetailsFetch = new DoctorLogin();
                drdetailsFetch = null;
                return drdetailsFetch;
            }

        }

    }
}
