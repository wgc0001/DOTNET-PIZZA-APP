using Microsoft.AspNetCore.Mvc;
using PizzaService;

namespace DOTNET_PIZZA_APP.Controllers;

[ApiController]
[Route("[api/controller]")]
public class PizzaController : ControllerBase
{
    private IPizzaService _PizzaService;

    [HttpGet("{Id}")]
    public IActionResult GetAllPizzaTypes()
    {
        return
    }

}