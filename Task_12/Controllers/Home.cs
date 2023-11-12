using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
namespace MvcApp 
{
    public class Home : Controller 
    {
        public IActionResult Index(string name, int age) 
        {
            return RedirectToAction("About", "Home", new {Name = name, Age = age});
        }
        public IActionResult About(string name, int age) => Content($"{name}: {age}");
        public IActionResult Contact() 
        {
            return RedirectToRoute("default", new {controller = "Home", action = "Index", Name = "Tom", Age = "22"});
        }
        public IActionResult Contact2() 
        {
            return Redirect("https://metanit.com/sharp/aspnetmvc/2.7.php");
        }
        //Для постоянной переадресации
        public IActionResult Contact3() 
        {
            return RedirectPermanent("/Home/Index");
        }
        //Для временной переадресации на локальные ресурсы
        public IActionResult Contact4() 
        {
            return LocalRedirect("/Home/About");
        }
        //при попытке переадресации на сторонние сайты, не локальные, обработается исключение
        public IActionResult Contact5() 
        {
            return LocalRedirect("https://metanit.com/sharp/aspnetmvc/2.7.php");
        }
    }
}