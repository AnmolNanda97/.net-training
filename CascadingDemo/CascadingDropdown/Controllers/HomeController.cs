using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CascadingDropdown.Models;

namespace CascadingDropdown.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBFirstDemo entity = new DBFirstDemo();
            ViewBag.Countries = new SelectList(GetCountries(), "country_id", "country_name");
            return View();
        }

        public List<CountryTable> GetCountries()
        {
            DBFirstDemo entity = new DBFirstDemo();
            List<CountryTable> countries = entity.CountryTables.ToList();
            return countries;
        }

        public ActionResult GetStates(int cid)
        {
            DBFirstDemo entity = new DBFirstDemo();
            List<StateTable> states = entity.StateTables.Where(x=>x.country_id==cid).ToList();
            ViewBag.States = new SelectList(states, "state_id", "state_name");
            return PartialView("DisplayStates");
        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}