using System;
using System.Collections.Generic;

namespace PatientAPI.Models
{
    public partial class TblDoctor
    {
        public TblDoctor()
        {
            TblAppointment = new HashSet<TblAppointment>();
        }

        public int SNo { get; set; }
        public string DrUserId { get; set; }
        public string DrFirstName { get; set; }
        public string DrLastName { get; set; }
        public int? DrAge { get; set; }
        public string DrGender { get; set; }
        public DateTime? DrDob { get; set; }
        public long? DrContactNo { get; set; }
        public long? DrAltContactNo { get; set; }
        public string DrEmail { get; set; }
        public string DrPassword { get; set; }
        public string DrAddress1 { get; set; }
        public string DrAddress2 { get; set; }
        public string DrCity { get; set; }
        public string DrState { get; set; }
        public long? DrZipcode { get; set; }
        public string DrDegree { get; set; }
        public string DrSpeciality { get; set; }
        public string DrWorkHours { get; set; }
        public string DrClinicName { get; set; }
        public string DrMdMedicareServiceId { get; set; }
        public bool? DrStatus { get; set; }

        public TblMedicare DrMdMedicareService { get; set; }
        public ICollection<TblAppointment> TblAppointment { get; set; }
    }
}
