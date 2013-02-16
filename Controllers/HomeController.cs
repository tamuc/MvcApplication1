using System;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var christopher = new Person("Christopher", DateTime.Parse("11/11/1989"));

            return this.View(christopher);
        }
    }
}