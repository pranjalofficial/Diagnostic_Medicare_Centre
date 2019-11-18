using System;
using System.Collections.Generic;

namespace PatientAPI.Models
{
    public partial class TblAppointment
    {
        public int Sno { get; set; }
        public string ApAppointmentId { get; set; }
        public string ApDrUserId { get; set; }
        public string ApMdMedicareServiceId { get; set; }
        public string ApPtUserId { get; set; }
        public DateTime? ApDate { get; set; }
        public TimeSpan? ApTime { get; set; }
        public bool? ApStatus { get; set; }

        public TblDoctor ApDrUser { get; set; }
        public TblMedicare ApMdMedicareService { get; set; }
        public TblPatient ApPtUser { get; set; }
    }
}
