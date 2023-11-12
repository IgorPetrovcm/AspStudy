using Microsoft.AspNetCore.Mvc;
namespace MvcApp.Controllers 
{
    class Home : Controller 
    {
        Persons persons = new Persons();
        [HttpGet] 
        public async Task Index() 
        {
            Response.ContentType = @"text/html; charset=""utf-8""";
            string text = @"<form method=""get"">
            <label>Name</label> <br />
            <input name=""name"" /> <br />
            <input name=""send"" type=""submit"" />
            </form>";
            await Response.WriteAsync(text);
        }
    }
    class Persons 
    {
        public string[] Names;
        public Persons() 
        {
            Names = new string[10];
        }
    }
}