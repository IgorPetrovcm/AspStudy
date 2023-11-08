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
        [ActionName("Index2")]
        public async Task Index2() 
        {
            Response.ContentType = "text=html; charser=utf-8";
            string html = "<p>JRKNk Kjrjr rjhrs uuoqw b oen ehdjjdjf uwheb bsbvv,x.z zuhd ,z,c uifha nwuii</p>";
            await Response.WriteAsync(html);
        }
    }
}