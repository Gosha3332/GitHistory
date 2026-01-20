var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/getRepositoryGit/{owner}/{repo}", async (string owner, string repo) =>
{
    string token = "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";
    HttpClient client = new HttpClient();
    try
    {
        HttpResponseMessage resultJson = await client.GetAsync($"https://api.github.com/user?access_token={token}/{owner}/{repo}");
        if (resultJson != null)
        {
            GitRepository repository = new GitRepository
            (
                $"https://api.github.com/user?access_token={token}/{owner}/{repo}"
            );
        }
        else { return "Такого репозитория нету"; }
    }
    catch (Exception e) { Console.WriteLine(e); }
    return null;
});

app.Run();
