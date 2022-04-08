using Microsoft.AspNetCore.Mvc;


namespace dojoSurvey
{

    public class SurveyController : Controller
    {

        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }


        [HttpPost("postForm")]
        public IActionResult postForm(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Info");
        }

    }

}