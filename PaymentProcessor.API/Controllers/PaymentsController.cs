using Microsoft.AspNetCore.Mvc;

namespace PaymentProcessor.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Pagamento obtido com sucesso!");
    }
}
