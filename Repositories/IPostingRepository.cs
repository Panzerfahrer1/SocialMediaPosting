using _03Social_Media_Postings.Models;

namespace _03Social_Media_Postings.Repositories
{
    public interface IPostingRepository
    {
        public List<Posting> GetAllPostings(string? Author = null, DateTime? postDate = null, bool sortByLikes = false);
        public void CreatePosting(Posting posting);
        public void EditPosting(int postingId, PostingDto posting);
        public void DeletePosting(int postingId);
        public void LikePosting(int postingId);
        public Posting? GetPostingById(int postingId);
    }
}
