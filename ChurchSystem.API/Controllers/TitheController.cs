using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ChurchSystem.API;


[ApiController]
[Route("[controller]")]
public class TitheController : ControllerBase
{


    private readonly ILogger<TitheController> _logger;

    public TitheController(ILogger<TitheController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTithe")]
    public async Task<IActionResult> Get()
    {
        return null;
    }
}
