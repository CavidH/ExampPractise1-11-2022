using Microsoft.AspNetCore.Mvc;

namespace ExampPractise.Area.AdminExam.Controllers
{
    public class Feature : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}