using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
app.UseRouting();
app.MapControllerRoute(name:"default", pattern:"{contoller=Home}/{action=Index}/{id?}");

app.Run();
