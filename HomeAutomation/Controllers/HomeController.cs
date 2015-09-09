using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using HomeAutomation.Models;

namespace HomeAutomation.Controllers
{
    public class HomeController : Controller
    {
        private PropertyScaffolding1Context db = new PropertyScaffolding1Context();

        public ActionResult Index()
        {
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

        // GET: /Home/Dashboard/5
        //Took below from controller that was created when using scaffolding on Property model, removed the controller that was created with that and all the CRUD view files
        public ActionResult Dashboard(int? id)
        {
            //Todo: unhardcoded
            id = 2;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Property property = db.Properties.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

    }
}