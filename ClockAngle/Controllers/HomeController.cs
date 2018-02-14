using Microsoft.AspNetCore.Mvc;
using ClockAngle.Models;
using System.Collections.Generic;

namespace ClockAngle.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/clock")]
        public ActionResult ClockDisplay()
        {
          Clock newClock = new Clock(int.Parse(Request.Form["hours"]), int.Parse(Request.Form["minutes"]));
          newClock.CalculateMinutes();
          newClock.ToDegrees();
          return View(newClock);
        }
    }
}
