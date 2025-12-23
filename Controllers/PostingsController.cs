using _03Social_Media_Postings.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03Social_Media_Postings.Controllers
{
    public class PostingsController : Controller
    {
        // In-memory list to store postings
        private static List<Posting> postings = new List<Posting>
        {
            new Posting("Hello, world!", "Adam"),
            new Posting("Just had a great lunch.", "Dora"),
            new Posting("Enjoying the sunny weather.", "Oliver"),
            new Posting("Enjoying the sunny weather.", "Lukas"),
            new Posting("Enjoying the sunny weather.", "Franz")
        };

        public IActionResult Index()
        {
            return View(postings);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Like()
        {
            return View();
        }
    }
}
