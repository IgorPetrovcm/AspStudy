using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Structs;
namespace MvcApp.Controllers 
{
    public class Home : Controller
    {
        public PersonsStorage personStore;
        public Home(PersonsStorage personStore) {
            this.personStore = personStore;
        }
        [HttpGet]
        public async Task Index()
        {
            Response.ContentType = "text/html;charset=utf-8";

            string content = @"<form method='post'>
                <label>Name:</label><br />
                <input name='name' /><br />
                <input type='submit' value='Send' />
            </form>";

            await Response.WriteAsync(content);
        }
        [HttpPost] 
        public void Index(string name) 
        { 
            Persons person = new Persons(name);
            personStore.persons.Add(person);

        }
        [HttpGet]
        public async Task Index2() 
        {
            StringBuilder strBuild = new StringBuilder();
            Response.ContentType = @"text/html; charset='utf-8'";

            foreach (var person in personStore.persons) 
            {
                Console.WriteLine(person.Name);
                strBuild.Append($"<p>{person.Name}</p>");    
            }
            Console.WriteLine(strBuild.ToString());

            await Response.WriteAsync(strBuild.ToString());
        }

    }
}
namespace Structs 
{
    public class Persons 
    {
        public string Name;
        public Persons(string name) 
        {
            Name = name;
        }
    }
    public class PersonsStorage 
    {
        public List<Persons> persons = new List<Persons>();
        
    }
}