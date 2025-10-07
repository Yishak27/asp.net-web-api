var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/add", () =>
{
    return "yes";
});

app.MapGet("/*", () =>
{
    return "catch all";
});
app.Run();