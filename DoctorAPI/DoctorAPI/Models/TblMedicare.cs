using System;
using System.Collections.Generic;

namespace DoctorAPI.Models
{
    public partial class TblMedicare
    {
        public TblMedicare()
        {
            TblAppointment = new HashSet<TblAppointment>();
            TblDoctor = new HashSet<TblDoctor>();
            TblMedicalTestHistory = new HashSet<TblMedicalTestHistory>();
        }

        public int SNo { get; set; }
        public string MdMedicareId { get; set; }
        public string MdMedicareService { get; set; }
        public string MdServiceDesp { get; set; }
        public long? MdAmount { get; set; }

        public ICollection<TblAppointment> TblAppointment { get; set; }
        public ICollection<TblDoctor> TblDoctor { get; set; }
        public ICollection<TblMedicalTestHistory> TblMedicalTestHistory { get; set; }
    }
}
