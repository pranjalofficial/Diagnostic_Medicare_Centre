using System;
using System.Collections.Generic;

namespace PatientAPI.Models
{
    public partial class TblPatient
    {
        public TblPatient()
        {
            TblAppointment = new HashSet<TblAppointment>();
        }

        public int Sno { get; set; }
        public string PtUserId { get; set; }
        public string PtFirstName { get; set; }
        public string PtLastName { get; set; }
        public int? PtAge { get; set; }
        public string PtGender { get; set; }
        public DateTime? PtDob { get; set; }
        public long? PtContactNo { get; set; }
        public long? PtAltContactNo { get; set; }
        public string PtEmail { get; set; }
        public string PtPassword { get; set; }
        public string PtAddress1 { get; set; }
        public string PtAddress2 { get; set; }
        public string PtCity { get; set; }
        public string PtState { get; set; }
        public long? PtZipcode { get; set; }
        public bool? PtStatus { get; set; }

        public ICollection<TblAppointment> TblAppointment { get; set; }
    }
}
