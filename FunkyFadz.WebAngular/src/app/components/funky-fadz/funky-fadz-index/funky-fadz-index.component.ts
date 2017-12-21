import { Component, OnInit } from '@angular/core';
import { FunkyFadzService} from '../../../services/funky-fadz.service';
import { FunkyFadz} from '../../../models/FunkyFadz';
import { DataSource} from '@angular/cdk/collections';
import { Observable} from 'rxjs/Observable';
import 'rxjs/add/observable/of';

@Component({
  selector: 'app-funky-fadz-index',
  templateUrl: './funky-fadz-index.component.html',
  styleUrls: ['./funky-fadz-index.component.css']
})
export class FunkyFadzIndexComponent implements OnInit {

    funkyfadz: FunkyFadz[];
    columnNames = ['FunkyFadzId', 'FadType', 'Description', 'Year', 'CreatedUtc', 'buttons'];
    dataSource: FunkyFadzSource | null;

  constructor(private _funkyFadzService: FunkyFadzService) { }

  ngOnInit() {
    this._funkyFadzService.getFunkyFadz().subscribe((funkyfadz:FunkyFadz[]) => {
      this.dataSource = new FunkyFadzSource(funkyfadz);
    });
  }

}
export class FunkyFadzSource extends DataSource<any> {

  constructor(private notesData: FunkyFadz[]) {
    super();
  }

  connect(): Observable<FunkyFadz[]> {
    return Observable.of(this.notesData);
  }

  disconnect() { }
}


