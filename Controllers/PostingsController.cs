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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Posting posting)
        {
            _postingRepository.CreatePosting(posting);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int postingId)
        {
            return View(_postingRepository.GetPostingById(postingId));
        }

        [HttpPost]
        public IActionResult Edit(int id, PostingDto posting)
        {
            _postingRepository.EditPosting(id, posting);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int postingId)
        {
            return View(_postingRepository.GetPostingById(postingId));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult FinalDelete(int postingId)
        {
            _postingRepository.DeletePosting(postingId);
            return RedirectToAction("Index");
        }

        public IActionResult Like()
        {
            return View();
        }
    }
}
