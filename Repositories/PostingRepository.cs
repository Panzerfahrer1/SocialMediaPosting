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

        public void CreatePosting(Posting posting)
        {
            if(!IsPostingValid(posting))
            {
                throw new ArgumentException("Invalid posting data.");
            }
            
            postings.Add(posting);
        }

        public void DeletePosting(int postingId)
        {
            var post = postings.FirstOrDefault(p => p.Id == postingId);
            if (post != null)
            {
                postings.Remove(post);
            }
        }

        public void EditPosting(int id, PostingDto updatedPost)
        {
            var oldPost = postings.FirstOrDefault(p => p.Id == id);
            if (oldPost == null)
            {
                throw new Exception("Posting not found.");  
            }

            oldPost.Text = updatedPost.Text;
            oldPost.UpdatedDate = DateTime.Now;
        }

        public void LikePosting(int postingId)
        {
            var post = postings.FirstOrDefault(p => p.Id == postingId);

            if(post == null)
            {
                throw new Exception("Posting not found.");
            }

            post.Likes += 1;
        }

        public List<Posting> GetAllPostings()
        {
            return postings;
        }

        private bool IsPostingValid(Posting posting)
        {
            if (string.IsNullOrEmpty(posting.Text))
            {
                return false;
            }
            return true;
        }

        public Posting? GetPostingById(int postingId)
        {
            var posting = postings.FirstOrDefault(p => p.Id == postingId);

            if (posting == null)
            {
                throw new ArgumentException("This ID does not exist");
            }

            return posting;
        }
    }
}
