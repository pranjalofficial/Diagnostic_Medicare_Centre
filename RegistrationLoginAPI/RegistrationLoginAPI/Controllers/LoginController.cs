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
    public class LoginController : ControllerBase
    {
        Medicare_SystemContext msc = new Medicare_SystemContext();


        // POST: api/Login
        [HttpPost]
        public PatientDetailsFetch Post([FromBody] TblPatient patientLogin)
        {
          
          TblPatient patient =  msc.TblPatient.FromSql("patientauthentication '" + patientLogin.PtUserId + "','" + patientLogin.PtPassword + "'").SingleOrDefault();
            
            if (patient !=null)
            {
                
                    PatientDetailsFetch detailsFetch = new PatientDetailsFetch();
                    detailsFetch.PtUserId = patient.PtUserId;
                    detailsFetch.PtFirstName = patient.PtFirstName;
                    detailsFetch.PtLastName = patient.PtLastName;
                    detailsFetch.PtEmail = patient.PtEmail;
                    
                
                return detailsFetch;
            }
            else
            {
                PatientDetailsFetch detailsFetch = new PatientDetailsFetch();
                detailsFetch = null;
                return detailsFetch;
            }
          
        }


        // POST: api/DoctorLogin
       

    }
}
