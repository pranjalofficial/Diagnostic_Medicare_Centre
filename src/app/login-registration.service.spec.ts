import { TestBed } from '@angular/core/testing';

import { LoginRegistrationService } from './login-registration.service';

describe('LoginRegistrationService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: LoginRegistrationService = TestBed.get(LoginRegistrationService);
    expect(service).toBeTruthy();
  });
});
