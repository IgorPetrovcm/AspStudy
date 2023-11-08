using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MvcApp.Controllers 
{
    public class HomeController : Controller 
    {
        public async Task Index() 
        {
            Response.ContentType = "text/html; charset=utf-8";
            StringBuilder html = new (@"<h1>response text</h1> <table border=""1px"">");
            foreach (var header in Request.Headers) 
            {
                html.Append($"<tr> <td>{header.Key}</td> <td>{header.Value}</td></tr>");
            }
            html.Append("</table>");
            await Response.WriteAsync(html.ToString());
        }
    }
}