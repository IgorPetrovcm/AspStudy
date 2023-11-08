using Microsoft.AspNetCore.Mvc;
namespace MvcApp.Controllers 
{
    public class Home : Controller 
    {        
        [HttpGet]
        public async Task Index() 
        {
            string htmlText = @"<form method=""post"">
            <label>Name:</lable> <br />
            <input name=""name"" type=""text"" /> <br />
            <lable>Age:</lable> <br />
            <input name=""age"" type=""number""> <br />
            <input name=""send"" type=""submit"" value=""Send"" />
            </form>";

            Response.ContentType = @"text/html; charset=""utf-8""";
            await Response.WriteAsync(htmlText);
        }
        [HttpPost]
        public string Index(string name, int age) => $"name user: {name}\nage user: {age}";
    }
}