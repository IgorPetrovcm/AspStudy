var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<Structs.Employees>();
var app = builder.Build();
app.MapControllerRoute(name:"default", pattern:"{controller=Home}/{action=Index}");

app.Run();
