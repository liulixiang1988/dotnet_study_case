using api_demo.Workers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api_demo.Controllers;

public class DynamicLoaderController(IServiceProvider serviceProvider, ILogger<DynamicLoaderController> logger): ControllerBase
{
    [HttpGet("dynamic/{modelName}")]
    [ProducesResponseType(200, Type = typeof(string))]
    public async Task<IActionResult> AnyDataDemoAsync(string modelName)
    {
        var worker = serviceProvider.GetRequiredKeyedService<IWorker>(modelName);
        var result = await worker.DoWorkAsync();
        return Ok(result);
    }
}