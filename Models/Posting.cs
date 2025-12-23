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

        public int Likes { get; private set; }

        public Posting()
        {
            Id = _nextId++;
            CreatedDate = DateTime.Now;
            Likes = 0;
        }

        public Posting(string text, string? author = null)
        {
            if(!CheckPost(text))
            {
                throw new ArgumentException("Post text cannot exceed 280 characters.");
            }

            Id = _nextId++;
            Author = author;
            CreatedDate = DateTime.Now;
            Likes = 0;
        }

        /// <summary>
        /// Updates the text content with the specified value if it does not exceed 280 characters.
        /// </summary>
        /// <param name="newText">The new text to set. Must not be longer than 280 characters.</param>
        /// <returns>true if the text was updated successfully; otherwise, false.</returns>
        public bool UpdateText(string newText)
        {
            if(!CheckPost(newText))
            {
                return false;
            }

            Text = newText;
            UpdatedDate = DateTime.Now;

            return true;
        }

        /// <summary>
        /// Determines whether the specified post text meets the maximum length requirement.
        /// </summary>
        /// <param name="text">The text of the post to validate. Must not exceed 280 characters.</param>
        /// <returns>true if the post text length is 280 characters or fewer; otherwise, false.</returns>
        public bool CheckPost(string text) => text.Length <= 280;
    }
}