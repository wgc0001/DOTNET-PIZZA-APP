using DOTNET_PIZZA_APP.Controllers;
using Microsoft.AspNetCore.Mvc;
using PizzaService;

var builder = WebApplication.CreateBuilder(args);

// Add your service
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddDbContext<DataContext>(); 

var app = builder.Build();
app.UseRouting();
// Define your API endpoint, passing the request object
app.MapPost("/api/pizza/createorder", (PizzaController controller) =>
{
    return (HttpRequest request) => controller.CreateOrder(request);
});

app.MapGet("/api/pizza/types", async ([FromServices] PizzaController controller) =>
{
        try
    {
        var pizzaTypes = await controller.GetPizzaTypes();
        return Results.Json(pizzaTypes);
    }
    catch (Exception ex)
    {
        return Results.Problem(detail: ex.Message);
    }
});

app.Run();

