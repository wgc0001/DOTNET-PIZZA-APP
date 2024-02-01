using PizzaService;
using PizzaModels;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace DOTNET_PIZZA_APP.Controllers;
public class PizzaController
{
    private IOrderService _OrderService;

    public PizzaController(IOrderService OrderService)
    {
        _OrderService = OrderService;
    }
    public async Task<IResult> CreateOrder(HttpRequest request)
    {
        try
        {
            using (var reader = new StreamReader(request.Body))
            {
                var orderJson = await reader.ReadToEndAsync();
                var order = JsonSerializer.Deserialize<Order>(orderJson);

                var createdOrder = await _OrderService.CreateOrderAsync(order);

                return Results.Json(createdOrder);
            }
        }
        catch (ArgumentException ex)
        {
            return Results.BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return Results.StatusCode(500);
        }
    }
    public async Task<IResult> GetPizzaTypes()
    {
    try
    {
        var pizzaTypes = await _OrderService.GetPizzaTypesAsync();
        return Results.Json(pizzaTypes); // Use Results.Json for clarity
    }
    catch (Exception ex)
    {
        return Results.Problem(detail: ex.Message); // Handle errors gracefully
    }
    }
}
