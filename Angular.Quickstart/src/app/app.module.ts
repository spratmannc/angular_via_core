import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';
import { ToolbarComponent } from './toolbar/toolbar.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent, ToolbarComponent ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
