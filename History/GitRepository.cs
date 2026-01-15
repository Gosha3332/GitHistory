public class GitRepository
{
    public string Url { get; set; }
    public string Name { get; set; }
    public int StarsCount { get; set; }
    public DateOnly LastDateEditRepository { get; set; }
    public string Language { get; set; }
    public List<(DateTime Date, int CommitCount)> HistoryCommit { get; set; }




    GitRepository() { }
}
