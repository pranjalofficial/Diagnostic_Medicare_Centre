import { Time } from '@angular/common';

export interface IAppointmentStatus
{
    sno:number;
    apAppointmentId:string; 
    apDrUser?:string;
    apDrUserId:string;   
    apMdMedicareService?:string;
    apMdMedicareServiceId:string; 
    apPtUser?:string;
    apPtUserId : string;
    apDate :Date;
    apTime :Time;
    apStatus :boolean;
}