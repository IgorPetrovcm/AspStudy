var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); //добавляем объекту builder поддержку контроллеров
var app = builder.Build();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index2}/{id?}"); //настраиваем сопоставление маршрутов с контроллерами

app.Run();
