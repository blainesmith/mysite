using System.Web.Mvc;

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

    }
}
