import { Component, OnInit } from '@angular/core';
import { Department } from '../department';
import {DepartmentService} from '../department.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {
  dep = new Department();

  constructor(private ds:DepartmentService) { }

  ngOnInit() {
  }

saveDept(){
  this.ds.save(this.dep);
}


}
