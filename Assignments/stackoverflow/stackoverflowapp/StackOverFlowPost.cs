namespace StackOverFlow{
public class StackOverFlow
{
    private int _voteCount;

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreationTime { get; }

    public int VoteCount
    {
        get { return _voteCount; }
    }

    public StackOverFlow(string title, string description)
    {
        Title = title;
        Description = description;
        CreationTime = DateTime.Now;
        _voteCount = 0;
    }

    public void UpVote()
    {
        _voteCount++;
    }

    public void DownVote()
    {
        _voteCount--;
    }
}

}