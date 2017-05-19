import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: `<h1>Hello {{name}}</h1>
    <toolbar></toolbar>
  `,
})
export class AppComponent  { name = 'Tonya and Alaina and Roger'; }
