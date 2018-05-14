import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { MDModule } from '../md.module';
import { CommonModule } from '../common/common.module';

import { UserComponent } from './pages/user.component';
import { SettingsComponent } from './pages/settings/settings.component';
import { FriendsComponent } from './pages/friends/friends.component';

@NgModule({
  declarations: [
    UserComponent,
    SettingsComponent,
    FriendsComponent
  ],
  imports: [
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forChild([
      {
        path: 'user',
        component: UserComponent,
        children: [
          { path: '', redirectTo: 'settings', pathMatch: 'full' },
          { path: 'settings', component: SettingsComponent },
          { path: 'friends', component: FriendsComponent }
        ]
      }
    ]),
    MDModule,
    CommonModule
  ],
  exports: [
    UserComponent,
    SettingsComponent,
    FriendsComponent
  ],
  providers: []
})
export class UserModule { }
