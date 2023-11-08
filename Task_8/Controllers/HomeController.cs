using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MvcApp.Controllers 
{
    class HomeController : Controller 
    {
        public async Task Index() 
        {
            Response.ContentType = @"text/html; charset=""utf-8""";
            StringBuilder textHtml = new (@"<h1>Hello!</h1> <table border=""1px"">");

            foreach (var header in Response.Headers) 
            {
                textHtml.Append($"<tr> <td>{header.Key}<td> <td>{header.Value}</td> </tr>");
            }
            textHtml.Append("</table>");
            await Response.WriteAsync(textHtml.ToString());
        }
    }
} 