using System;
using System.Collections.Generic;

namespace PatientAPI.Models
{
    public partial class TblMedicalTestHistory
    {
        public int Sno { get; set; }
        public string MtReportId { get; set; }
        public string MtPtUserId { get; set; }
        public string MtDrUserId { get; set; }
        public string MtMdMedicareServiceId { get; set; }
        public DateTime? MtServiceDate { get; set; }
        public DateTime? MtTestResultDate { get; set; }
        public decimal? MtDiag1ActualValue { get; set; }
        public decimal? MtDiag1NormalRange { get; set; }
        public decimal? MtDiag2ActualValue { get; set; }
        public decimal? MtDiag2NormalRange { get; set; }
        public decimal? MtDiag3ActualValue { get; set; }
        public decimal? MtDiag3NormalRange { get; set; }
        public decimal? MtDiag4ActualValue { get; set; }
        public decimal? MtDiag4NormalRange { get; set; }
        public string MtDoctorComments { get; set; }
        public string MtOtherInfo { get; set; }

        public TblMedicare MtMdMedicareService { get; set; }
    }
}
