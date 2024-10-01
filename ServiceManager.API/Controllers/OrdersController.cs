using Microsoft.AspNetCore.Mvc;

namespace ServiceManager.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Pedido realizado com sucesso!");
    }
}
