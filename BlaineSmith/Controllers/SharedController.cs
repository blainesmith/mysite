﻿using System.Web.Mvc;

namespace BlaineSmith.Controllers
{
    public class SharedController : Controller
    {
        //
        // GET: /Shared/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return PartialView();
        }

        public ActionResult NavAccessoryLayout()
        {
            return PartialView();
        }

        public ActionResult SiteFooter()
        {
            return PartialView();
        }

        public ActionResult MessageBox()
        {
            return PartialView();
        }

    }
}
