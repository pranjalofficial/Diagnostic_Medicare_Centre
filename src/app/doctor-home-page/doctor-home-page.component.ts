import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { DoctorAppointmentStatusService } from "../doctor-appointment-status.service";
import { IAppointmentStatus } from "../appointmentStatusModule";
import { debug } from "util";
import { doctorLoginDetails } from "../doctor-login/doctorLoginDetails";
import { AuthService } from "../auth.service";
import { bookingpagemedicare } from "../medicareServiceAppointment";
import { AppointmentService } from "../appointment.service";
import { MedicareTestHistoryService } from "../medicare-test-history.service";
import { IMedicareDetails } from "../IMedicareDetails";
import { FormBuilder } from '@angular/forms';

@Component({
  selector: "app-doctor-home-page",
  templateUrl: "./doctor-home-page.component.html",
  styleUrls: ["./doctor-home-page.component.css"]
})
export class DoctorHomePageComponent implements OnInit {
  constructor(
    private _router: Router,
    private appointment: DoctorAppointmentStatusService,
    private _authService: AuthService,
    private medicare: AppointmentService,
    private update: MedicareTestHistoryService
  ) {}
  drDetails: doctorLoginDetails = {
    drMedicareId:null,
    drFirstName: null,
    drLastName: null,
    drUserId: null,
    sNo: null
  };
  appointmentDetails: IAppointmentStatus[] = [
    {
      sno: null,
      apAppointmentId: null,
      apDrUser: null,
      apDrUserId: null,
      apMdMedicareService: null,
      apMdMedicareServiceId: null,
      apPtUser: null,
      apPtUserId: null,
      apDate: null,
      apTime: null,
      apStatus: null
    }
  ];
  medicareDetails: bookingpagemedicare[] = [
    {
      sno: null,
      mdMedicareId: null,
      mdMedicareService: null
    }
  ];
  fullMedicareDetails: IMedicareDetails = null;
  drAppointment: IAppointmentStatus[] = null;
  ngOnInit() {
    this.drDetails = this._authService.fetchDoctor;
    this.appointment
      .appointmentStatus(this.drDetails.drUserId)
      .subscribe((res: IAppointmentStatus[]) => {
        this.appointmentDetails = [...res];
      });
    this.appointment
      .doctorAppointmentList(this.drDetails.drUserId)
      .subscribe((res: IAppointmentStatus[]) => {
        this.drAppointment = [...res];
      });
    this.medicare.medicareService().subscribe((res: bookingpagemedicare[]) => {
      this.medicareDetails = [...res];
    });
    this.update.getModifyMedicare(this.drDetails.drMedicareId).subscribe((res: IMedicareDetails) => {
      this.fullMedicareDetails = res;
    });
  }
  approve(id: string) {
    this.appointment.approveStatus(id).subscribe(() => {
      this.appointment
        .appointmentStatus(this.drDetails.drUserId)
        .subscribe((res: IAppointmentStatus[]) => {
          this.appointmentDetails = [...res];
        });
    });
  }

  deny(id: string) {
    this.appointment.denyStatus(id).subscribe(() => {
      this.appointment
        .appointmentStatus(this.drDetails.drUserId)
        .subscribe((res: IAppointmentStatus[]) => {
          this.appointmentDetails = [...res];
        });
    });
  }

  onChange(id: string) {
    
  }

  onSubmit() {
    debugger
    this.update.modifyMedicareService(this.fullMedicareDetails).subscribe();
  }
}
