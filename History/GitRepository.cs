public class GitRepository
{

    public string Url { get; set; }
    public string Name { get; private set; }
    public int StarsCount { get; private set; }
    public DateOnly LastDateEditRepository { get; private set; }
    public string Language { get; private set; }
    public List<(DateTime Date, int CommitCount)> HistoryCommit { get; private set; }
    public GitRepository(string url, string name, int starsCount, DateOnly lastDateEditRepository, string language, List<(DateTime Date, int CommitCount)> historyCommit)
    {
        Url = url;
        Name = name;
        StarsCount = starsCount;
        LastDateEditRepository = lastDateEditRepository;
        Language = language;
        HistoryCommit = historyCommit;
    }

    public void PaintGrafic() { }
}
