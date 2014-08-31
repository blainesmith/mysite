using System.Web.Mvc;

namespace BlaineSmith.Controllers
{
    public class BlogsController : Controller
    {
        public ActionResult Blog()
        {
            return PartialView();
        }

        public ActionResult BlogEntry()
        {
            return PartialView();
        }

        public ActionResult BlogConstruction()
        {
            return PartialView();
        }
    }
}
