import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IAppointmentStatus } from './appointmentStatusModule';

@Injectable({
  providedIn: 'root'
})
export class DoctorAppointmentStatusService {

  constructor(private http:HttpClient) { }
statusUrl:string = "http://localhost:1432/api/AppointmentStatus";
appointmentListUrl:string = "http://localhost:16693/api/Doctor";
appointmentStatus(id:string):Observable<IAppointmentStatus[]>
{
  return this.http.get<IAppointmentStatus[]>(this.statusUrl+"/"+id);
}
approveStatus(id:string):Observable<{}>{
  return this.http.put(this.statusUrl+"/"+id,{headers: new HttpHeaders({'Content-type': 'application/json'})
});
}

denyStatus(id:string){
  return this.http.delete(this.statusUrl+"/"+id);
}

doctorAppointmentList(id:string):Observable<IAppointmentStatus[]>{
  return this.http.get<IAppointmentStatus[]>(this.appointmentListUrl+"/"+id);
}
}
