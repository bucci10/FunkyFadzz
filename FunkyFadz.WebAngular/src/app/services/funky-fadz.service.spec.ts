import { TestBed, inject } from '@angular/core/testing';

import { FunkyFadzService } from './funky-fadz.service';

describe('FunkyFadzService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [FunkyFadzService]
    });
  });

  it('should be created', inject([FunkyFadzService], (service: FunkyFadzService) => {
    expect(service).toBeTruthy();
  }));
});
