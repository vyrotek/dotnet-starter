import { Component, Input } from '@angular/core';
import { MatSidenav } from '@angular/material';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {

  @Input('sideNav') sideNav: MatSidenav;
  @Input() isMobile: boolean;

  public toggleSidenav() {
    if (this.sideNav) {
      this.sideNav.toggle();
    }
  }

}
