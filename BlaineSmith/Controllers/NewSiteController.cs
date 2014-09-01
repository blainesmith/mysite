using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlaineSmith.Controllers
{
    public class NewSiteController : Controller
    {
        public ActionResult Home()
        {
            return PartialView();
        }

        public ActionResult Blog()
        {
            return PartialView();
        }

        public ActionResult Contact()
        {
            return PartialView();
        }

        public ActionResult Portfolio()
        {
            return PartialView();
        }

        public ActionResult PortfolioSingle()
        {
            return PartialView();
        }

        public ActionResult Service()
        {
            return PartialView();
        }

        public ActionResult SinglePost()
        {
            return PartialView();
        }

        public ActionResult About()
        {
            return PartialView();
        }


    }
}
