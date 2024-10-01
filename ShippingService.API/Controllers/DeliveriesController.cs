using Microsoft.AspNetCore.Mvc;

namespace ShippingService.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DeliveriesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Entrega realizada com sucesso!");
    }
}
