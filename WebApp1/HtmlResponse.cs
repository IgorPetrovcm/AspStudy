using Microsoft.AspNetCore.Mvc;
namespace MvcApp 
{
    public class HtmlResponse : IActionResult 
    {
        public string html;
        public HtmlResponse(string html) => this.html = html;

        public async Task ExecuteResultAsync(ActionContext context) 
        {
            string htmlFull = 
            @$"<!doctype html>
            <html>
                <head>
                    <title>WebApp1</title>
                    <meta charset='utf-8' />
                </head>
                <body>
                    {html}
                </body>
            </html>";
            await context.HttpContext.Response.WriteAsync(htmlFull);
        }
    }
}