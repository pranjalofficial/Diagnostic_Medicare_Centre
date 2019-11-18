import { TestBed } from '@angular/core/testing';

import { DoctorAppointmentStatusService } from './doctor-appointment-status.service';

describe('DoctorAppointmentStatusService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DoctorAppointmentStatusService = TestBed.get(DoctorAppointmentStatusService);
    expect(service).toBeTruthy();
  });
});
