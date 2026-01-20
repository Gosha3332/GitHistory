var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/getRepositoryGit/{owner}/{repo}", async (string owner, string repo) =>
{
    string token = "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";
    HttpClient client = new HttpClient();
    try
    {
        HttpResponseMessage resultJson = await client.GetAsync($"https://api.github.com/user?access_token={token}/{owner}/{repo}");
        if (!resultJson.IsSuccessStatusCode) //Проверка на обработку запроса
        {
            if (resultJson.StatusCode != System.Net.HttpStatusCode.NotFound)//проверка на нахождение реозитория
            {
                GitRepository repository = new GitRepository
                (
                    $"https://api.github.com/user?access_token={token}/{owner}/{repo}"
                );

                //Здесь у меня будет возвращатся обработанная инфа репозитория
            }
            else { return "Такого репозитория нет"; }
        }
        else { return "Запрос не обработан"; }
    }
    catch (Exception e) { Console.WriteLine(e); }
    return null;
});

app.Run();
