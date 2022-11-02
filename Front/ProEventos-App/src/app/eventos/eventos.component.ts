import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [
    {
      Tema: 'Angular 11',
      Local: 'São Paulo'
    },
    {
      Tema: '.NET 5 + Angular 11',
      Local: 'Peruíbe'
    },
    {
      Tema: 'Entity Framework',
      Local: 'Belo Horizonte'
    },
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
