using Site.Models;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}