using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ChurchSystem.API.Models;
using System;
using System.Linq;

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
        var tithe = await _titheService.GetAllTithes();
        return Ok(tithe);
    }
}
