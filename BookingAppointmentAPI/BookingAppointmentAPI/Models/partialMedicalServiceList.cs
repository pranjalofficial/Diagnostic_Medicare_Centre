using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointmentAPI.Models
{
    public class partialMedicalServiceList
    {
        public int Sno { get; set; }
        public string MdMedicareId { get; set; }
        public string MdMedicareService { get; set; }
    }
}
