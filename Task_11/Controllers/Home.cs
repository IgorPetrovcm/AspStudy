using Microsoft.AspNetCore.Mvc;
namespace MvcApp 
{
    public class Home : Controller 
    {
        public IActionResult Index() 
        {
            return new HtmlResult("<h1>HELLO WORLD!!!</h1>");
        }
    }
}