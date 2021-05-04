import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HomeComponent } from './home/home.component';
import { FriendComponent } from './friend/friend.component';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

export class Friend{
  constructor(
    public Id:Number,
    public f_name:string,
    public m_name:string,
    public l_name:string,
    public address:string,
    public birthDate:string,
    public score:string,
    public dep_id:string
  ){

  }
}

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    FriendComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
