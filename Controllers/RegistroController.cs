using Microsoft.AspNetCore.Mvc;
using HagenApi.Interfaces;
using HagenApi.Models.Request;
using HagenApi.Models.Responses;

namespace HagenApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RegistroController : ControllerBase
{
    private readonly ILogger<RegistroController> _logger;
    IRegistroServices service;

    public RegistroController(ILogger<RegistroController> logger,IRegistroServices _services)
    {
        _logger = logger;
        service = _services;
    }

[HttpPost]
[Route("api/Add")]
public async Task<ActionResult<GeneralResponse>> Add([FromBody]AddRecord request)
{
    var response = await service.AgregaRegistro(request);
    if(response.CodigoEstatus!=200)
    {
        return BadRequest(response);
    }
    return Ok(response);
}

[HttpPost]
[Route("api/AddPersonal")]
public async Task<ActionResult<GeneralResponse>> AddPersonal(AddPersonal request)
{
    var response = await service.AgregaDatosPersonales(request);
    if(response.CodigoEstatus!=200)
    {
        return BadRequest(response);
    }
    return Ok(response);
}
}
