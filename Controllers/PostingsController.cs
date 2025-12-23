using _03Social_Media_Postings.Models;
using _03Social_Media_Postings.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _03Social_Media_Postings.Controllers
{
    public class PostingsController : Controller
    {
        private readonly IPostingRepository _postingRepository;
        public PostingsController(IPostingRepository repos) { 
            _postingRepository = repos;
        }

        public IActionResult Index()
        {
            return View(_postingRepository.GetAllPostings());
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
