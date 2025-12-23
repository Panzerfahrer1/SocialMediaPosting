namespace _03Social_Media_Postings.Repositories
{
    public interface IPostingRepository
    {
        public bool ShowAllPostings();
        public void CreatePosting();
        public void EditPosting();
        public void DeletePosting();
        public void LikePosting();

        //This is a test comment to check git changes
    }
}
