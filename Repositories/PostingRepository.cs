using _03Social_Media_Postings.Models;

namespace _03Social_Media_Postings.Repositories
{
    public class PostingRepository : IPostingRepository
    {
        private static List<Posting> postings = new List<Posting>
        {
            new Posting("Hello, world!", "Adam"),
            new Posting("Just had a great lunch.", "Dora"),
            new Posting("Enjoying the sunny weather.", "Oliver"),
            new Posting("Enjoying the sunny weather.", "Lukas"),
            new Posting("Enjoying the sunny weather.", "Franz")
        };

        public void CreatePosting()
        {
            throw new NotImplementedException();
        }

        public void DeletePosting()
        {
            throw new NotImplementedException();
        }

        public void EditPosting()
        {
            throw new NotImplementedException();
        }

        public void LikePosting()
        {
            throw new NotImplementedException();
        }

        public List<Posting> GetAllPostings()
        {
            return postings;
        }
    }
}
