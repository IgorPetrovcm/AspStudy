
using Microsoft.AspNetCore.Mvc;
using MvcApp;
namespace MvcApp.Controllers 
{
    public class Home : Controller
    {
        
        public IActionResult Index() 
        {
            string html = @"<form method='post'>
            <label>1.Открыть редактор программистов</label> <br />
            <label>2.Окрыть редактор бухгалтеров</label> <br />
            <label>3.Открыть список программистов</label> <br />
            <label>4.Открыть список бухгалтеров</label> <br />
            <input name='input' type='number' max='4' min='1' /> 
            <input name='send' value='Send' type='submit' />
            </form>";
            return new HtmlResponse(html);
        }
        [HttpPost] 
        public IActionResult Index(int input) 
        {
            if (input == 1) 
            {
                return Redirect("/Home/EditProgrammers");
            }
            return null;
        }

        public IActionResult EditProgrammers() 
        {
            string html = @"<form method='post'>
            <label>Name programmer</label> <br/>
            <input name='name'> <br/>
            <input name='send' type='submit' value='Send' />
            </form>";
            return new HtmlResponse(html);
        }
    }
}