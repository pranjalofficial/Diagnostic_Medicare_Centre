using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationLoginAPI.Models
{
    public class DoctorLogin
    {
        public int SNo { get; set; }
        public string DrUserId { get; set; }
        public string DrFirstName { get; set; }
        public string DrLastName { get; set; }
        public string DrMdMedicareServiceId { get; set; }
    }
}
