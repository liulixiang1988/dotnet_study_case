using Microsoft.AspNetCore.Mvc;

namespace aspnet_demo.Controllers;

public class ErrorController: ControllerBase
{
    private readonly ILogger<ErrorController> _logger;

    public ErrorController(ILogger<ErrorController> logger)
    {
        _logger = logger;
    }

    [Route("/error")]
    public string Error()
    {
        _logger.LogInformation("error controller, {test}", Configs.LocalValue.Value);
        return "internal error";
    } 
}