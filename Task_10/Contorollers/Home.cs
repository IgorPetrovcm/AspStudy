using System.Reflection.Metadata.Ecma335;
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

        [ActionName("Index2")]
        [HttpGet]
        public async Task Index2() 
        {
            string htmlText = @"<form method=""post"">
            <label>Name</lable> <br />
            <input name=""name"" type=""text"" /> <br />
            <label>Age</label> <br />
            <input name=""age"" type=""number"" /> <br />
            <input name=""send"" type=""submit"" value=""Send"" />
            </form>";
            
            Response.ContentType = @"text/html; charset=""utf-8""";
            await Response.WriteAsync(htmlText);
        }
        [HttpPost]
        public string Index2(Person person) => $"Person name: {person.name}\nPerson age: {person.age}";

        public record class Person(string name, int age);

        [ActionName("Index3")]
        [HttpGet]
        public async Task Index3() 
        {
            string htmlText = @"<form method=""post"">
            <lable>Name</label> <input name=""names"" type=""text"" /> <br />
            <lable>Name</lable> <input name=""names"" type=""text"" /> <br />
            <lable>Name</lable> <input name=""names"" type=""text"" /> <br />
            <input name=""send"" type=""submit"" value=""Send"">
            </form>";

            Response.ContentType = @"text/html; charset=""utf-8""";
            await Response.WriteAsync(htmlText);            
        }
        [HttpPost]
        public string Index3(string[] names) 
        {
            string result = "";
            foreach (string name in names) 
            {
                result += "\n" + name;
            }
            return result;
        }
    }
}