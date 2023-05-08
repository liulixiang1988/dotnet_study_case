using Microsoft.AspNetCore.Mvc;

namespace aspnet_demo.Controllers;

public class DemoController: ControllerBase
{
    [HttpPost("text:analyze")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<string>))]
    [ProducesResponseType(400)]
    public IActionResult TextAnalyzeWithLanguage()
    {
        return Ok("demo");
    }
}