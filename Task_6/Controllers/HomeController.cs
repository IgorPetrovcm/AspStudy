using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    //создадим контроллер 'HomeController' и определим в нем метод 'Index' для сопоставления с запросами:
    public class HomeController : Controller 
    {
        //при обращении к этому действию приложение отправит в ответ пользователю строку
        public string Index() 
        {
            return "Hello World!";
        }
        //[ActionName("Index2")]
        public string Index2() 
        {
            return "Check";
        }
    }
    [NonController]
    public class NewController : Controller 
    {
        [NonAction]
        public string Index() 
        { 
            return "";
        }
    }
}
