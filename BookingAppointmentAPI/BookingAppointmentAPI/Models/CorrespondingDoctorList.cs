using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointmentAPI.Models
{
    public class CorrespondingDoctorList
    {
        public int SNo { get; set; }
        public string DrUserId { get; set; }
        public string DrFirstName { get; set; }
        public string DrLastName { get; set; }
    }
}
