using Microsoft.AspNetCore.Mvc;
using BasicAuth.Models;

namespace BasicAuth.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
