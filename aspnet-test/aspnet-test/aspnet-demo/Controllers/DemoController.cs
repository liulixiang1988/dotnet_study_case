using Microsoft.AspNetCore.Mvc;

namespace aspnet_demo.Controllers;

public class DemoController: ControllerBase
{
    [HttpPost("text:analyze")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<string>))]
    [ProducesResponseType(400)]
    public IActionResult TextAnalyzeWithLanguage()
    {
        Console.WriteLine("-----------text:analyze-----------");
        foreach (var routeDataValue in RouteData.Values)
        {
            Console.WriteLine(routeDataValue.Key + " " + routeDataValue.Value);
        }
        return Ok("demo");
    }
    [HttpGet("hello/{user}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<string>))]
    [ProducesResponseType(400)]
    public IActionResult TextAnalyzeWithLanguage(string user)
    {
        Console.WriteLine("-----------text:analyze-----------");
        foreach (var routeDataValue in RouteData.Values)
        {
            Console.WriteLine(routeDataValue.Key + " " + routeDataValue.Value);
        }
        return Ok(user);
    }
}