using Microsoft.AspNetCore.Mvc;

namespace dojo_survey_csharp
{

    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
        public ViewResult Survey()
        {   
            // Views/Home/HiThere.cshtml
            // returning view with no argument will look for the file name of your action
            // you can also provide a name
            return View("survey");
        }

        [HttpGet("results")]
        public ViewResult Results()
        {   
            // Views/Home/HiThere.cshtml
            // returning view with no argument will look for the file name of your action
            // you can also provide a name
            return View("results");
        }
        // remember to use [HttpPost] attributes!
        [HttpPost]
        [Route("method")]
        public IActionResult Method(string name, string location, string language, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View("results");
        }
    }
}