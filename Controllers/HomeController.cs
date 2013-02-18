using System;
using System.Web.Mvc;
using MvcApplication1.Models;
//using MvcApplication1.Models.Person;
using MvcApplication1.Models.Robot;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var christopher = new Person("Christopher", DateTime.Parse("11/11/1989"));
            var robotOne = new Robot("Tesla", DateTime.Parse("2/17/2013"), false);
            var robotTwo = new Robot("Laplace", DateTime.Parse("2/17/2013"), false);
            var robotThree = new Robot("Differential Equations", DateTime.Parse("2/29/2013"), true);

            //return this.View(christopher);
            return this.View(robotOne);
        }
    }
}