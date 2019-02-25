using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCNovicell.Controllers
{
    public class HelloNovicellController : Controller
    {
        //GET: /HelloNovicell/
        public IActionResult Index() {
            return View();
        }

        // GET: /HelloNovicell/Welcome
        //Uses interpolated string '$'
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}