import { TestBed } from '@angular/core/testing';

import { F1SimpleService } from './f1-simple.service';

describe('F1SimpleService', () => {
  let service: F1SimpleService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(F1SimpleService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
