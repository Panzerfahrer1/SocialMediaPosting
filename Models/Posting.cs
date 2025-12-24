namespace _03Social_Media_Postings.Models
{
    public class Posting
    {
        private static int _nextId = 1;
        public int Id { get; private set; }
        public string Text { get; set; }
        public string? Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public int Likes { get; set; }

        public Posting()
        {
            Id = _nextId++;
            CreatedDate = DateTime.Now;
            Likes = 0;
        }
        
        public Posting(string text, string? author = null)
        {
            Id = _nextId++;
            Author = author;
            CreatedDate = DateTime.Now;
            Likes = 0;
        }
    }
}