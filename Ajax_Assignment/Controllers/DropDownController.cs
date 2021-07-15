using Ajax_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Ajax_Assignment.Controllers
{
    public class DropDownController : Controller
    {
        // GET: DropDown
        public ActionResult Index()
        {
            AjaxConceptEntities sd = new AjaxConceptEntities();
            ViewBag.CountryList = new SelectList(GetCountryList(), "Cid", "Cname");
            return View();
        }
        public List<Country> GetCountryList()
        {
            AjaxConceptEntities sd = new AjaxConceptEntities();
            List<Country> countries = sd.Countries.ToList();
            return countries;
        }
        public ActionResult GetStateList(int Cid)
        {
            AjaxConceptEntities sd = new AjaxConceptEntities();
            List<State> selectList = sd.States.Where(x => x.Cid == Cid).ToList();
            ViewBag.Slist = new SelectList(selectList, "Sid", "Sname");
            return PartialView("DisplayStates");
        }
        public ActionResult GetCityList(int Sid)
        {
            AjaxConceptEntities sd = new AjaxConceptEntities();
            List<City> selectList = sd.Cities.Where(x => x.Sid == Sid).ToList();
            ViewBag.Citylist = new SelectList(selectList, "Cityid", "Cityname");
            return PartialView("DisplayCities");
        }
    }
}