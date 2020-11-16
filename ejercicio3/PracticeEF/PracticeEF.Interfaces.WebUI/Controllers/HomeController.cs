using PracticeEF.CrossCutting.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeEF.Interfaces.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RequestApiWeatherGeo requestApiWeatherGeo = new RequestApiWeatherGeo();
            ViewBag.Weather = requestApiWeatherGeo.GetInfoWeather();
            return View();
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