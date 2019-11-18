import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { bookingpagemedicare } from './medicareServiceAppointment';
import { Observable } from 'rxjs';
import { appoDetails } from './appointmentDetailsModule';
import { IAppointmentStatus } from './appointmentStatusModule';
import { doctorLoginDetails } from './doctor-login/doctorLoginDetails';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {

  constructor(private http:HttpClient) { }

  medicareUrl:string = "http://localhost:1432/api/BookingAppointment";
  patientUrl:string = "http://localhost:31024/api/Appointment";
  medicareDetails:bookingpagemedicare;
  drdetails:doctorLoginDetails;
  appointmentsDetails:appoDetails;
  medicareService():Observable<bookingpagemedicare[]>{
    return this.http.get<bookingpagemedicare[]>(this.medicareUrl);
  }

  doctorDetails(id:string):Observable<doctorLoginDetails[]>{
      return this.http.get<doctorLoginDetails[]>(this.medicareUrl+"/"+id);
  }

  bookingAppointmant(appointmentsDetails:appoDetails){
    return this.http.post<appoDetails>(this.medicareUrl,appointmentsDetails,{headers: new HttpHeaders({'Content-type': 'application/json'})
  }
    )
}

viewAppointmentDetails(id:string):Observable<IAppointmentStatus[]>{
  return this.http.get<IAppointmentStatus[]>(this.patientUrl+"/"+id);
}
}
