var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 2+2);

app.Run();
