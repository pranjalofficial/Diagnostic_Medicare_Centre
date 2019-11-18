using System;
using System.Collections.Generic;

namespace PatientAPI.Models
{
    public partial class TblAdmin
    {
        public int Sno { get; set; }
        public string AdAdminId { get; set; }
        public string AdFirstName { get; set; }
        public string AdLastName { get; set; }
        public int? AdAge { get; set; }
        public string AdGender { get; set; }
        public DateTime? AdDob { get; set; }
        public long? AdContactNo { get; set; }
        public long? AdAltContactNo { get; set; }
        public string AdEmail { get; set; }
        public string AdPassword { get; set; }
    }
}
