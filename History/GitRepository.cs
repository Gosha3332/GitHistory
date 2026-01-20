public class GitRepository
{
    public string Url { get; set; }
    public string Name { get; private set; }
    public int StarsCount { get; private set; }
    public DateOnly LastDateEditRepository { get; private set; }
    public string Language { get; private set; }
    public List<(DateTime Date, int CommitCount)> HistoryCommit { get; private set; }

    public GitRepository(string Url) { this.Url = Url; }


    public void PaintGrafic() { }
}
