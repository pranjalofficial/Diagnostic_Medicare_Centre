using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationLoginAPI.Models
{
    public class PatientDetailsFetch
    {
        public string PtUserId { get; set; }
        public string PtFirstName { get; set; }
        public string PtLastName { get; set; }
        public string PtEmail { get; set; }
    }
}
