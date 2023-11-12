using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
namespace MvcApp.Controllers 
{
    public class HomeController : Controller
    {
        public string Index() { return "Hello World";}
    }
}