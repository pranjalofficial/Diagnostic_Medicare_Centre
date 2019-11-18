using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegistrationLoginAPI.Models
{
    public partial class Medicare_SystemContext : DbContext
    {
        public Medicare_SystemContext()
        {
        }

        public Medicare_SystemContext(DbContextOptions<Medicare_SystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblAppointment> TblAppointment { get; set; }
        public virtual DbSet<TblDoctor> TblDoctor { get; set; }
        public virtual DbSet<TblMedicalTestHistory> TblMedicalTestHistory { get; set; }
        public virtual DbSet<TblMedicare> TblMedicare { get; set; }
        public virtual DbSet<TblPatient> TblPatient { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local);Database=Medicare_System;Trusted_connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.HasKey(e => e.AdAdminId);

                entity.ToTable("tblAdmin");

                entity.Property(e => e.AdAdminId)
                    .HasColumnName("ad_AdminId")
                    .HasMaxLength(12)
                    .HasComputedColumnSql("('Ad'+CONVERT([nvarchar](10),[sno]))")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdAge).HasColumnName("ad_Age");

                entity.Property(e => e.AdAltContactNo).HasColumnName("ad_AltContactNo");

                entity.Property(e => e.AdContactNo).HasColumnName("ad_ContactNo");

                entity.Property(e => e.AdDob)
                    .HasColumnName("ad_Dob")
                    .HasColumnType("date");

                entity.Property(e => e.AdEmail)
                    .HasColumnName("ad_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.AdFirstName)
                    .IsRequired()
                    .HasColumnName("ad_FirstName")
                    .HasMaxLength(10);

                entity.Property(e => e.AdGender)
                    .HasColumnName("ad_Gender")
                    .HasMaxLength(10);

                entity.Property(e => e.AdLastName)
                    .HasColumnName("ad_LastName")
                    .HasMaxLength(10);

                entity.Property(e => e.AdPassword)
                    .HasColumnName("ad_Password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblAppointment>(entity =>
            {
                entity.HasKey(e => e.ApAppointmentId);

                entity.ToTable("tblAppointment");

                entity.Property(e => e.ApAppointmentId)
                    .HasColumnName("ap_AppointmentId")
                    .HasMaxLength(14)
                    .HasComputedColumnSql("('Ap'+CONVERT([nvarchar](12),[sno]))")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApDate)
                    .HasColumnName("ap_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ApDrUserId)
                    .HasColumnName("ap_dr_UserId")
                    .HasMaxLength(12);

                entity.Property(e => e.ApMdMedicareServiceId)
                    .HasColumnName("ap_md_MedicareServiceId")
                    .HasMaxLength(12);

                entity.Property(e => e.ApPtUserId)
                    .HasColumnName("ap_pt_UserId")
                    .HasMaxLength(12);

                entity.Property(e => e.ApStatus)
                    .HasColumnName("ap_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApTime).HasColumnName("ap_Time");

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.ApDrUser)
                    .WithMany(p => p.TblAppointment)
                    .HasForeignKey(d => d.ApDrUserId)
                    .HasConstraintName("ap_dr_FK");

                entity.HasOne(d => d.ApMdMedicareService)
                    .WithMany(p => p.TblAppointment)
                    .HasForeignKey(d => d.ApMdMedicareServiceId)
                    .HasConstraintName("ap_md_FK");

                entity.HasOne(d => d.ApPtUser)
                    .WithMany(p => p.TblAppointment)
                    .HasForeignKey(d => d.ApPtUserId)
                    .HasConstraintName("ap_pt_FK");
            });

            modelBuilder.Entity<TblDoctor>(entity =>
            {
                entity.HasKey(e => e.DrUserId);

                entity.ToTable("tblDoctor");

                entity.Property(e => e.DrUserId)
                    .HasColumnName("dr_UserId")
                    .HasMaxLength(12)
                    .HasComputedColumnSql("('Dr'+CONVERT([nvarchar](10),[s_no]))")
                    .ValueGeneratedNever();

                entity.Property(e => e.DrAddress1)
                    .HasColumnName("dr_Address1")
                    .HasMaxLength(100);

                entity.Property(e => e.DrAddress2)
                    .HasColumnName("dr_Address2")
                    .HasMaxLength(100);

                entity.Property(e => e.DrAge).HasColumnName("dr_Age");

                entity.Property(e => e.DrAltContactNo).HasColumnName("dr_AltContactNo");

                entity.Property(e => e.DrCity)
                    .HasColumnName("dr_City")
                    .HasMaxLength(50);

                entity.Property(e => e.DrClinicName)
                    .HasColumnName("dr_ClinicName")
                    .HasMaxLength(50);

                entity.Property(e => e.DrContactNo).HasColumnName("dr_ContactNo");

                entity.Property(e => e.DrDegree)
                    .HasColumnName("dr_Degree")
                    .HasMaxLength(50);

                entity.Property(e => e.DrDob)
                    .HasColumnName("dr_Dob")
                    .HasColumnType("date");

                entity.Property(e => e.DrEmail)
                    .HasColumnName("dr_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.DrFirstName)
                    .IsRequired()
                    .HasColumnName("dr_FirstName")
                    .HasMaxLength(10);

                entity.Property(e => e.DrGender)
                    .HasColumnName("dr_Gender")
                    .HasMaxLength(10);

                entity.Property(e => e.DrLastName)
                    .HasColumnName("dr_LastName")
                    .HasMaxLength(10);

                entity.Property(e => e.DrMdMedicareServiceId)
                    .HasColumnName("dr_md_MedicareServiceId")
                    .HasMaxLength(12);

                entity.Property(e => e.DrPassword)
                    .HasColumnName("dr_Password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DrSpeciality)
                    .HasColumnName("dr_Speciality")
                    .HasMaxLength(50);

                entity.Property(e => e.DrState)
                    .HasColumnName("dr_State")
                    .HasMaxLength(100);

                entity.Property(e => e.DrStatus)
                    .HasColumnName("dr_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DrWorkHours)
                    .HasColumnName("dr_WorkHours")
                    .HasMaxLength(10);

                entity.Property(e => e.DrZipcode).HasColumnName("dr_Zipcode");

                entity.Property(e => e.SNo)
                    .HasColumnName("s_no")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.DrMdMedicareService)
                    .WithMany(p => p.TblDoctor)
                    .HasForeignKey(d => d.DrMdMedicareServiceId)
                    .HasConstraintName("dr_md_FK");
            });

            modelBuilder.Entity<TblMedicalTestHistory>(entity =>
            {
                entity.HasKey(e => e.MtReportId);

                entity.ToTable("tblMedicalTestHistory");

                entity.Property(e => e.MtReportId)
                    .HasColumnName("mt_ReportId")
                    .HasMaxLength(12)
                    .HasComputedColumnSql("('Mt'+CONVERT([nvarchar](10),[sno]))")
                    .ValueGeneratedNever();

                entity.Property(e => e.MtDiag1ActualValue)
                    .HasColumnName("mt_Diag1ActualValue")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MtDiag1NormalRange)
                    .HasColumnName("mt_Diag1NormalRange")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MtDiag2ActualValue)
                    .HasColumnName("mt_Diag2ActualValue")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MtDiag2NormalRange)
                    .HasColumnName("mt_Diag2NormalRange")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MtDiag3ActualValue)
                    .HasColumnName("mt_Diag3ActualValue")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MtDiag3NormalRange)
                    .HasColumnName("mt_Diag3NormalRange")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MtDiag4ActualValue)
                    .HasColumnName("mt_Diag4ActualValue")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MtDiag4NormalRange)
                    .HasColumnName("mt_Diag4NormalRange")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MtDoctorComments)
                    .HasColumnName("mt_DoctorComments")
                    .HasMaxLength(300);

                entity.Property(e => e.MtDrUserId)
                    .HasColumnName("mt_dr_UserId")
                    .HasMaxLength(11);

                entity.Property(e => e.MtMdMedicareServiceId)
                    .HasColumnName("mt_md_MedicareServiceId")
                    .HasMaxLength(12);

                entity.Property(e => e.MtOtherInfo)
                    .HasColumnName("mt_OtherInfo")
                    .HasMaxLength(300);

                entity.Property(e => e.MtPtUserId)
                    .HasColumnName("mt_pt_UserId")
                    .HasMaxLength(11);

                entity.Property(e => e.MtServiceDate)
                    .HasColumnName("mt_ServiceDate")
                    .HasColumnType("date");

                entity.Property(e => e.MtTestResultDate)
                    .HasColumnName("mt_TestResultDate")
                    .HasColumnType("date");

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.MtMdMedicareService)
                    .WithMany(p => p.TblMedicalTestHistory)
                    .HasForeignKey(d => d.MtMdMedicareServiceId)
                    .HasConstraintName("mt_md_FK");
            });

            modelBuilder.Entity<TblMedicare>(entity =>
            {
                entity.HasKey(e => e.MdMedicareId);

                entity.ToTable("tblMedicare");

                entity.Property(e => e.MdMedicareId)
                    .HasColumnName("md_MedicareId")
                    .HasMaxLength(12)
                    .HasComputedColumnSql("('Md'+CONVERT([nvarchar](10),[s_no]))")
                    .ValueGeneratedNever();

                entity.Property(e => e.MdAmount).HasColumnName("md_Amount");

                entity.Property(e => e.MdMedicareService)
                    .HasColumnName("md_MedicareService")
                    .HasMaxLength(50);

                entity.Property(e => e.MdServiceDesp)
                    .HasColumnName("md_ServiceDesp")
                    .HasMaxLength(100);

                entity.Property(e => e.SNo)
                    .HasColumnName("s_no")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblPatient>(entity =>
            {
                entity.HasKey(e => e.PtUserId);

                entity.ToTable("tblPatient");

                entity.Property(e => e.PtUserId)
                    .HasColumnName("pt_UserId")
                    .HasMaxLength(12)
                    .HasComputedColumnSql("('Pt'+CONVERT([nvarchar](10),[sno]))")
                    .ValueGeneratedNever();

                entity.Property(e => e.PtAddress1)
                    .HasColumnName("pt_Address1")
                    .HasMaxLength(100);

                entity.Property(e => e.PtAddress2)
                    .HasColumnName("pt_Address2")
                    .HasMaxLength(100);

                entity.Property(e => e.PtAge).HasColumnName("pt_Age");

                entity.Property(e => e.PtAltContactNo).HasColumnName("pt_AltContactNo");

                entity.Property(e => e.PtCity)
                    .HasColumnName("pt_City")
                    .HasMaxLength(50);

                entity.Property(e => e.PtContactNo).HasColumnName("pt_ContactNo");

                entity.Property(e => e.PtDob)
                    .HasColumnName("pt_Dob")
                    .HasColumnType("date");

                entity.Property(e => e.PtEmail)
                    .HasColumnName("pt_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.PtFirstName)
                    .IsRequired()
                    .HasColumnName("pt_FirstName")
                    .HasMaxLength(10);

                entity.Property(e => e.PtGender)
                    .HasColumnName("pt_Gender")
                    .HasMaxLength(10);

                entity.Property(e => e.PtLastName)
                    .HasColumnName("pt_LastName")
                    .HasMaxLength(10);

                entity.Property(e => e.PtPassword)
                    .HasColumnName("pt_Password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PtState)
                    .HasColumnName("pt_State")
                    .HasMaxLength(100);

                entity.Property(e => e.PtStatus).HasColumnName("pt_Status");

                entity.Property(e => e.PtZipcode).HasColumnName("pt_Zipcode");

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();
            });
        }
    }
}
