using Microsoft.AspNetCore.Mvc;
namespace MvcApp 
{
    public class Home : Controller 
    {
        public IActionResult Index() 
        {
            return new HtmlResult("<h1>HELLO WORLD!!!</h1>");
        }
        public IActionResult Index2() 
        {
            return Content("Hello World!");
        }
        //JsonResult
        public IActionResult Index3() 
        {
            Person person = new Person("Tom",22);
            Person[] persons = {person};
            return Json(persons); // json также возвращает и массивы
        }
    }
    public record class Person(string name, int age);
}