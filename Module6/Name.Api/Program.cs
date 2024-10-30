var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.MapGet("/", () => Results.Ok("Cesar"));

app.Run();

