using Microsoft.EntityFrameworkCore;
using PizzaModels;
using System;
using System.Collections.Generic;

namespace PizzaService{
public interface IOrderService
{
     Task<Order> CreateOrderAsync(Order order);
     decimal GetPizzaPrice(PizzaType pizzaType, PizzaSize pizzaSize);
     decimal GetDrinkPrice(DrinkSize drinkSize);
     Task<IEnumerable<PizzaType>> GetPizzaTypesAsync();
}
public class OrderService : IOrderService
{
    private DataContext _context;
    public OrderService(DataContext context)
    {
        _context = context;
    }
    public async Task<Order> CreateOrderAsync(Order order)
    {
        // Validation:
        if (order.OrderItems.Count == 0){
            throw new ArgumentException("Order cannot be empty");
        }

        //Business Logic
        decimal totalPrice = 0;
        foreach (var item in order.OrderItems)
        {
            decimal pizzaPrice = GetPizzaPrice(item.PizzaType, item.PizzaSize);
            totalPrice += pizzaPrice;
        }

        foreach (var item in order.OrderItems)
        {
            decimal drinkPrice = GetDrinkPrice(item.DrinkSize);
            totalPrice += drinkPrice;
        }

        order.OrderPrice = (int)totalPrice;

        // Persistence
      await _context.Orders.AddAsync(order);
      await _context.SaveChangesAsync();
    

        return order;
    }
    public decimal GetPizzaPrice(PizzaType pizzaType, PizzaSize pizzaSize)
    {
 
        // Example using database lookup:
        var pizzaPrice = _context.PizzaPrices
            .FirstOrDefault(p => p.PizzaType == pizzaType && p.PizzaSize == pizzaSize);

        if (pizzaPrice == null)
        {
            throw new ArgumentException("Invalid pizza type or size");
        } else {

            return pizzaPrice.PizzaPriceAmount;
        }

    }
    public decimal GetDrinkPrice(DrinkSize drinkSize)
    {
        if (drinkSize == null)
        {
            throw new ArgumentException("Invalid drink size");
        } else {

            return drinkSize.DrinkSizePrice;
        }

    }
    public async Task<IEnumerable<PizzaType>> GetPizzaTypesAsync()
    {
        return await _context.PizzaTypes.ToListAsync();
    }
   
}

}