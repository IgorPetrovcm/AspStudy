using Microsoft.AspNetCore.Mvc;
namespace MvcApp.Controllers 
{
    public class Home : Controller 
    {
        [HttpGet]
        public async Task Index() 
        {            
            Response.ContentType = @"text/html;charset='utf-8'";
            string html = @"<form method='post'>
            <label>1.1site</label> <br/>
            <label>2.2site</label> <br/>
            <label>3.3site(is not working)</label> <br/>
            <input name='input' type='number' />
            <input name='send' type='submit' value='Send' />
            </form>";
            await Response.WriteAsync(html);
        }
        [HttpPost]
        public IActionResult Index(int input) 
        {
            if (input == 1)  return Ok("Successfully!");
            if (input == 2)  return Unauthorized("You dont registered");
            if (input == 3)  return NotFound("Site not found");
            else return BadRequest("Invalid input");
        }
    }
}