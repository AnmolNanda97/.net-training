import { Component, OnInit } from '@angular/core';
import { Department } from './../department';
import {DepartmentService} from './../department.service';

@Component({
  selector: 'app-deplist',
  templateUrl: './deplist.component.html',
  styleUrls: ['./deplist.component.scss']
})
export class DeplistComponent implements OnInit {

deplist:Department[];

department:Department;
  updatediv=false;
  indexposition:number;

  
  

  constructor(private ds:DepartmentService) { 
    this.deplist = this.ds.getDepartment();
  }


 edit(index:number)
   {   
     
     this.updatediv=true; 
     this.department=this.deplist[index];
     this.ds.update(this.department,this.indexposition);  
    }


  deleteEmplyee(index:number)
  {
    this.ds.delete(index);
   }



  ngOnInit() {
  }

}
