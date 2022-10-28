using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ChurchSystem.API;



namespace ChurchSystem.API;

[ApiController]
[Route("[controller]")]
public class TitheController : ControllerBase
{

    private readonly ITitheService _titheService;
    public TitheController(ITitheService titheService)
    {
        _titheService = titheService;
    }

    public TitheController()
    {

    }

    [HttpGet(Name = "GetTithe")]
    public async Task<IActionResult> Get()
    {
        var tithe = await _titheService.GetAllTithe();

        if (tithe.Any())
        {
            return Ok(tithe);
        }
        return NotFound();
    }

    // [HttpPost(Name = "PostTithe")]
    // public async Task<IActionResult> Post()
    // {
    //     var tithe = await _titheService.CreateTitheEntry();
    //     if (tithe != null)
    //     {
    //         return Ok(tithe);
    //     }
    //     return BadRequest();
    // }
}


