using CustomModel01.Models;
using System.Web.Mvc;

namespace CustomModel01.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login login)
        {
            if (ModelState.IsValid)
            {
            }
            return View();
        }
    }
}