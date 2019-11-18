import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ITestHistory } from './TestHistory';
import { Observable } from 'rxjs';
import { IMedicareDetails } from './IMedicareDetails';

@Injectable({
  providedIn: 'root'
})
export class MedicareTestHistoryService {

  constructor(private http:HttpClient) { }

  testHistoryUrl:string="http://localhost:31024/api/TestHistory";
  medicareUrl:string = "http://localhost:16693/api/Medicare";
  test:ITestHistory;
  fetchTestHistory(id:string):Observable<ITestHistory>{
    return this.http.get<ITestHistory>(this.testHistoryUrl+"/"+id);
  }
  getModifyMedicare(id:string):Observable<IMedicareDetails>{
    return this.http.get<IMedicareDetails>(this.medicareUrl+"/"+id);
  }
  modifyMedicareService(medicareUpdated:IMedicareDetails){
    debugger
    return this.http.put(this.medicareUrl,medicareUpdated,{headers: new HttpHeaders({'Content-type': 'application/json'})
  });
  }
}
