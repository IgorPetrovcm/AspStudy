using Microsoft.AspNetCore.Mvc;
namespace MvcApp.Controllers 
{
    public class HomeController : Controller 
    {
        public string Index(Person person) => $"{person.Name}: {person.Age}";
        public string Index2(string[] user)
        {
            string result = "";
            foreach (string name in user)
            {
                result += $"{name}; ";
            }
            return result;
        }
        public string Index3(Person[] persons) 
        {
            string result = "";
            foreach (Person person in persons)
            {
                result += $"{person.Name}: {person.Age}; ";
            }
            return result;
        }

        public record class Person(string Name, int Age);

    } 
}