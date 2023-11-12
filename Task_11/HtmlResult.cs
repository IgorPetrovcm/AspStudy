using Microsoft.AspNetCore.Mvc;
namespace MvcApp 
{
    public class HtmlResult : IActionResult 
    {
        string html;
        public HtmlResult(string html) => this.html = html;
        public async Task ExecuteResultAsync(ActionContext context) 
        {
            string htmlFull = @$"<!doctype html>
            <html>
                <head>
                    <title>newSite</title>
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