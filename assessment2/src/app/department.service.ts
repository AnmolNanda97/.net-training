import { Injectable } from '@angular/core';
import { Department } from './department';
@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  deptlist:Department[]=[
    {deptId:1,name:"Engineering",groupName:"Research and development",modifiedDate:new Date('01/06/2002')},
    {deptId:2,name:"Tool Design",groupName:"Research and development",modifiedDate:new Date('01/06/2002')},
    {deptId:3,name:"Sales",groupName:"Sales and marketing",modifiedDate:new Date('01/06/2002')},
  ];

  constructor() { }

  getDepartment(){
    return this.deptlist;
  }

  save(dep:Department){
    this.deptlist.push(dep);
  }

  delete(index :number)
  {
    this.deptlist.splice(index,1);
  }

  update(dep:Department,index:number)
   {
      this.deptlist[index]=dep;
       }

}
