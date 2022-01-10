using System.Threading.Tasks;
using ExampPractise.DAL;
using ExampPractise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExampPractise.Area.AdminExam.Controllers
{
    [Area("AdminExam")]
    public class Feature : Controller
    {
        // GET
        public AppDbContext _context { get; }

        public Feature(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var FeatureCards = await _context.FeatureCards.ToListAsync();
            return View(FeatureCards);
        }

        public async Task<IActionResult> Update(int id)
        {
            var card = await _context.FeatureCards.FindAsync(id);
            return View(card);
        }
        [HttpPost]

        public async Task<IActionResult> Update(FeatureCard featureCard, int id)
        {
            var card = await _context.FeatureCards.FindAsync(id);
            card.Title = featureCard.Title;
            card.Content = featureCard.Content;
            card.IconLink = featureCard.IconLink;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FeatureCard featureCard)
        {
            await _context.FeatureCards.AddAsync(new FeatureCard
            {
                Title = featureCard.Title,
                Content = featureCard.Content,
                IconLink = featureCard.IconLink
            });
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var card = await _context.FeatureCards.FindAsync(id);
            _context.Remove(card);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}