using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampPractise.DAL;
using ExampPractise.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ExampPractise.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context { get; }

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>Index()
        {

            HomeVM homeVm = new HomeVM
            {
                FeatureCards = await _context.FeatureCards.ToListAsync()
            };
            return View(homeVm);
        }
    }
}
