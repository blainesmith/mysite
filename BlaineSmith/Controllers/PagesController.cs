using System.Web.Mvc;

namespace BlaineSmith.Controllers
{
    public class PagesController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Home()
        {
            return PartialView();
        }

        public ActionResult HomeConstruction()
        {
            return PartialView();
        }

        public ActionResult Contact()
        {
            return PartialView();
        }

        public ActionResult ContactForm()
        {
            return PartialView();
        }

        public ActionResult Portfolio()
        {
            return PartialView();
        }

        public ActionResult Resume()
        {
            return PartialView();
        }

    }
}
