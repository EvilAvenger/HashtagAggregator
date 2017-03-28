import {
  Component,
  OnInit
} from '@angular/core';

import { AppState } from '../app.service';
import { MessageService } from './shared/message.service';

@Component({
  selector: 'home',
  styleUrls: ['./home.component.scss'],
  templateUrl: './home.component.html',
  providers: [
    MessageService
  ],
})
export class HomeComponent implements OnInit {
  public localState = { value: '' };

  constructor(public appState: AppState, public messageService: MessageService) {

  }

  public ngOnInit() {
    console.log('###test init home ###')
    console.log(location.href);
  }

  public submitState(value: string) {
    this.appState.set('value', value);
    this.localState.value = '';
  }
}
