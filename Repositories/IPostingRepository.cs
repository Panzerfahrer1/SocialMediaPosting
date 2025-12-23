using _03Social_Media_Postings.Models;

namespace _03Social_Media_Postings.Repositories
{
    public interface IPostingRepository
    {
        public List<Posting> GetAllPostings();
        public void CreatePosting();
        public void EditPosting();
        public void DeletePosting();
        public void LikePosting();
    }
}
