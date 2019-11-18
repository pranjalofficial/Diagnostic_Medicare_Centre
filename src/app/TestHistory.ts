export interface ITestHistory
{
     sno:number; 
     mtReportId :string;
     mtPtUserId :string;
     mtDrUserId :string;
     mtMdMedicareServiceId:string; 
     mtMdMedicareService:string;
     mtServiceDate :Date;
     mtTestResultDate :Date;
     mtDiag1ActualValue :number;
     mtDiag1NormalRange :number;
     mtDiag2ActualValue :number;
     mtDiag2NormalRange :number;
     mtDiag3ActualValue :number;
     mtDiag3NormalRange :number;
     mtDiag4ActualValue :number;
     mtDiag4NormalRange :number;
     mtDoctorComments :string;
     mtOtherInfo :string;
}