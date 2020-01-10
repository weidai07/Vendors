using Microsoft.AspNetCore.Mvc;
 using Vendor.Models;

namespace  Vendor.Controllers
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