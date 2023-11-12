
using Microsoft.AspNetCore.Mvc;
using MvcApp;
using Structs;
using System.Text;
namespace MvcApp.Controllers 
{
    public class Home : Controller
    {
        Employees employees = new Employees();
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
            if (input == 1) return Redirect("/Home/EditProgrammers");
            if (input == 2) return Redirect("/Home/EditAccountants");
            if (input == 3) return Redirect("/Home/ListProgrammers");
            if (input == 4) return Redirect("/Home/ListAccountants");
            return Redirect("/Home/Index");
        }

        public IActionResult EditProgrammers() 
        {
            string html = @"<form method='post'>
            <label>Name programmer</label> <br/>
            <input name='name'> <br/>
            <label>1.Back</label> <br/>
            <input name='send' type='submit' value='Send' /> <br/>
            </form>";
            return new HtmlResponse(html);
        }
        [HttpPost]
        public IActionResult EditProgrammers(string name) 
        {
            if (name == "1") return Redirect("/Home/Index");
            if (name == null) return Redirect("/Home/EditProgrammers");            
            employees.programmers.Add(new Programmer(name));
            return Redirect("/Home/EditProgrammers");
        }
        
        public IActionResult EditAccountants() 
        {
            string html = @"<form method='post'>
            <label>Name programmer</label> <br/>
            <input name='name'> <br/>
            <label>1.Back</label> <br/>
            <input name='send' type='submit' value='Send' /> <br/>
            </form>";
            return new HtmlResponse(html);            
        }
        [HttpPost] 
        public IActionResult EditAccountants(string name) 
        {
            if (name == "1") return Redirect("/Home/Index");
            if (name == null) return Redirect("/Home/EditAccountants");
            employees.accountants.Add(new Accountant(name));
            return Redirect("/Home/EditAccountants");
        }

        public IActionResult ListProgrammers() 
        {
            StringBuilder strBuild = new StringBuilder();
            foreach (var programmer in employees.programmers) 
            {
                strBuild.Append($"<p>{programmer.name}</p>");
            }
            return new HtmlResponse(strBuild.ToString());
        }

        public IActionResult ListAccountants() 
        {
            StringBuilder strBuild = new StringBuilder();
            foreach (var accountant in employees.accountants) 
            {
                strBuild.Append($"<p>{accountant.name}</p>");
            }
            return new HtmlResponse(strBuild.ToString());
        }
    }
}