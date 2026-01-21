using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/getRepositoryGit/{owner}/{repo}", async (string owner, string repo) =>
{
    string token = "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";
    HttpClient client = new HttpClient();
    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("token", token);
    try
    {
        HttpResponseMessage result = await client.GetAsync($"https://api.github.com/{owner}/{repo}");
        if (!result.IsSuccessStatusCode) //Проверка на обработку запроса
        {
            if (result.StatusCode != System.Net.HttpStatusCode.NotFound)//проверка на нахождение реозитория
            {
                string json = await result.Content.ReadAsStringAsync();

                Dictionary<string, object> deserializeJson = JsonSerializer.Deserialize<Dictionary<string, object>>(json);

                GitRepository repository = new GitRepository
                (
                    $"https://api.github.com/{owner}/{repo}"
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
