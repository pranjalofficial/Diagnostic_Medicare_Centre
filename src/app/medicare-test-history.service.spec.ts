import { TestBed } from '@angular/core/testing';

import { MedicareTestHistoryService } from './medicare-test-history.service';

describe('MedicareTestHistoryService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MedicareTestHistoryService = TestBed.get(MedicareTestHistoryService);
    expect(service).toBeTruthy();
  });
});
