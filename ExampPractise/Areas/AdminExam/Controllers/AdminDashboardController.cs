using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampPractise.Area.AdminExam.Controllers
{
    public class AdminDashboardController : Controller
    {
        [Area("AdminExam")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
