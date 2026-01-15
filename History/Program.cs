var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//private string tok = "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";

app.MapGet("/", () => "Hello World!");


app.Run();
