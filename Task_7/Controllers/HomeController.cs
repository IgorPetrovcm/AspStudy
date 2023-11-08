using Microsoft.AspNetCore.Mvc;
using System.Text;
namespace MvcApp.Controllers
{
    public class HomeController : Controller 
    {
        public async Task Index() 
        {
            Response.ContentType = "text/html; charset=utf-8";
            StringBuilder newString = new (@"<h2>test headers request</h2> <table border=""1px"">");  

            foreach (var header in Request.Headers) 
            {
                newString.Append($"<tr> <td>{header.Key}</td> <td>{header.Value}</td> </tr>");
            }          
            newString.Append("</table>");
            await Response.WriteAsync(newString.ToString());
        }
    }
}
