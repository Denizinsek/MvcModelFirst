using DataExtractionLogin.Models;
using System.Linq;
using System.Web.Mvc;

namespace DataExtractionLogin.Controllers
{
    public class HomeController : Controller
    {
        MvcModelFirstEntities db = new MvcModelFirstEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}