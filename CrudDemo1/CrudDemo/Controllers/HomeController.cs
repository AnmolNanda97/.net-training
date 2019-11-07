using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudDemo.Models;

namespace CrudDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SampleDb sampleDb = new SampleDb();
            return View(sampleDb.DemotblEmployees.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DemotblEmployee emp)
        {
            SampleDb sampleDb = new SampleDb();
            sampleDb.DemotblEmployees.Add(emp);
            sampleDb.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Details(int id)
        {
            SampleDb sampleDb = new SampleDb();
           DemotblEmployee selectedEmployee=sampleDb.DemotblEmployees.FirstOrDefault(x => x.Id == id);

            return View(selectedEmployee);
        }


        public ActionResult Edit(int id)
        {
            SampleDb sampleDb = new SampleDb();
            DemotblEmployee selectedEmployee = sampleDb.DemotblEmployees.FirstOrDefault(x => x.Id == id);
            return View(selectedEmployee);
        }

        [HttpPost]

        public ActionResult Edit(DemotblEmployee demoemp)
        {
            SampleDb sampleDb = new SampleDb();
            //DemotblEmployee selectedEmployee = sampleDb.DemotblEmployees.FirstOrDefault(x => x.Id == demoemp.Id);
            //selectedEmployee.FullName = demoemp.FullName;
            //selectedEmployee.Gender = demoemp.Gender;
            //selectedEmployee.Age = demoemp.Age;
            //selectedEmployee.EmailAddress = demoemp.EmailAddress;
            //selectedEmployee.HireDate = demoemp.HireDate;
            //selectedEmployee.Salary= demoemp.Salary;
            //selectedEmployee.PersonalWebSite = demoemp.PersonalWebSite;

            sampleDb.Entry(demoemp).State = System.Data.Entity.EntityState.Modified;
            sampleDb.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Delete(int id)
        {
            SampleDb sampleDb = new SampleDb();
            DemotblEmployee selectedEmployee = sampleDb.DemotblEmployees.FirstOrDefault(x => x.Id == id);
            return View(selectedEmployee);
        }

        [HttpPost]
        public ActionResult Delete(DemotblEmployee demoemp)
        {
            SampleDb sampleDb = new SampleDb();
            DemotblEmployee selectedEmployee = sampleDb.DemotblEmployees.FirstOrDefault(x => x.Id == demoemp.Id);
            sampleDb.DemotblEmployees.Remove(selectedEmployee);
            sampleDb.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}