import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../auth.service';
import { patientLogin } from '../patientlogin.module';
import { loginDetails } from '../login-page/loginFetchDetails.module';
import { AppointmentService } from '../appointment.service';
import { Observable } from 'rxjs';
import { bookingpagemedicare } from '../medicareServiceAppointment';
import { appoDetails } from '../appointmentDetailsModule';
import { Time } from '@angular/common';
import { IAppointmentStatus } from '../appointmentStatusModule';
import { MedicareTestHistoryService } from '../medicare-test-history.service';
import { ITestHistory } from '../TestHistory';
import { doctorLoginDetails } from '../doctor-login/doctorLoginDetails';
import * as moment from 'moment'; 

@Component({
  selector: 'app-patient-home-page',
  templateUrl: './patient-home-page.component.html',
  styleUrls: ['./patient-home-page.component.css']
})
export class PatientHomePageComponent implements OnInit {

  constructor(private _router:Router,private _authService: AuthService,private medicare:AppointmentService,private testHistory:MedicareTestHistoryService) { }
  patient:loginDetails=
  {
    ptUserId:null,
    ptFirstName:null,
    ptLastName:null,
    ptEmail:null

  };
  appStatusDetails:IAppointmentStatus[]=[
    {
      sno:null,
      apAppointmentId:null,
      apDrUser:null, 
      apDrUserId:null,
      apMdMedicareService:null,
      apMdMedicareServiceId:null, 
      apPtUser:null,
      apPtUserId : null,
      apDate :null,
      apTime :null,
      apStatus :null
    }
  ];
  testResult:ITestHistory=
    {
      sno:null,
      mtReportId :null,
      mtPtUserId :null,
      mtDrUserId :null,
      mtMdMedicareService:null,
      mtMdMedicareServiceId:null, 
      mtServiceDate :null,
      mtTestResultDate :null,
      mtDiag1ActualValue :null,
      mtDiag1NormalRange :null,
      mtDiag2ActualValue :null,
      mtDiag2NormalRange :null,
      mtDiag3ActualValue :null,
      mtDiag3NormalRange :null,
      mtDiag4ActualValue :null,
      mtDiag4NormalRange :null,
      mtDoctorComments :null,
      mtOtherInfo :null
    }
  
  medicareDetails:bookingpagemedicare[]=[{
    sno:null,
    mdMedicareId:null,
    mdMedicareService:null
  
}];
newAppointment:appoDetails ={
    apDrUserId : null,
    apMdMedicareServiceId : null,
    apPtUserId:null,
    apDate:null,
    apTime:null
};
detailsdr:doctorLoginDetails[];
msg:string;
 minDate = moment(new Date()).format('YYYY-MM-DD'); 
 

  ngOnInit() {
    this.patient = this._authService.fetchDetails;
    this.medicare.medicareService().subscribe((
      res:bookingpagemedicare[])=>{
      this.medicareDetails = [...res];
    });
    this.medicare.viewAppointmentDetails(this.patient.ptUserId).subscribe((
      res:IAppointmentStatus[])=>{
        this.appStatusDetails = [...res];
      }
      );

    this.testHistory.fetchTestHistory(this.patient.ptUserId).subscribe((
      res:ITestHistory)=>{
        this.testResult = res;
      }
      );
  }
 logout()
 {
   this._authService.logOut();
   this._router.navigate(['/Login/']);
 }

 onChange(id:string){
 
   this.medicare.doctorDetails(id).subscribe((
    res:doctorLoginDetails[])=>{
      this.detailsdr = [...res];
    }
   )

 }

 onSubmit(){
   this.newAppointment.apPtUserId= this.patient.ptUserId;
  this.medicare.bookingAppointmant(this.newAppointment).subscribe();
  this.medicare.viewAppointmentDetails(this.patient.ptUserId).subscribe((
    res:IAppointmentStatus[])=>{
      this.appStatusDetails = [...res];
    }
    )
  this.msg = "Appointment has been booked and waiting for conformation. You can check the status in the status tab."
 }
  
}
