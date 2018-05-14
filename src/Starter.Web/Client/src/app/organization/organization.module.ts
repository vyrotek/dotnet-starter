import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { MDModule } from '../md.module';
import { CommonModule } from '../common/common.module';

import { OrganizationComponent } from './pages/organization.component';
import { UsersComponent } from './pages/users/users.component';
import { MessagesComponent } from './pages/messages/messages.component';
import { OverviewComponent } from './pages/overview/overview.component';
import { SettingsComponent } from './pages/settings/settings.component';
import { DetailsComponent } from './pages/settings/details/details.component';
import { MembersComponent } from './pages/settings/members/members.component';

@NgModule({
  declarations: [
    OrganizationComponent,
    UsersComponent,
    MessagesComponent,
    OverviewComponent,
    SettingsComponent,
    DetailsComponent,
    MembersComponent
  ],
  imports: [
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forChild([
      {
        path: 'organization',
        component: OrganizationComponent,
        children: [
          { path: '', redirectTo: 'overview', pathMatch: 'full' },
          { path: 'overview', component: OverviewComponent },
          { path: 'users', component: UsersComponent },
          { path: 'messages', component: MessagesComponent },
          {
            path: 'settings', component: SettingsComponent, children: [
              { path: '', redirectTo: 'details', pathMatch: 'full' },
              { path: 'details', component: DetailsComponent },
              { path: 'members', component: MembersComponent }
            ]
          }
        ]
      }
    ]),
    MDModule,
    CommonModule
  ],
  exports: [
    OrganizationComponent,
    UsersComponent,
    MessagesComponent,
    OverviewComponent,
    SettingsComponent,
    DetailsComponent,
    MembersComponent
  ],
})
export class OrganizationModule { }
