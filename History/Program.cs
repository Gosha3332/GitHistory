var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

public class GitRepository
{
    public string Url { get; set; }
    public string Name { get; set; }
    public DateOnly LastDateEditRepository { get; set; }
    public string Language { get; set; }
    public List<(DateTime Date, int CommitCount)> HistoryCommit { get; set; }



    GitRepository() { }
}
