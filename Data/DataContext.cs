using Microsoft.EntityFrameworkCore;
using PizzaModels;

public class DataContext: DbContext
{
    protected readonly IConfiguration Configuration;
    public DataContext(IConfiguration configuration){
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("PostgreSQL"));
    }
    public DbSet<DrinkSize> DrinkSizes {get; set; }
    public DbSet<DrinkType> DrinkTypes {get; set; }
    public DbSet<Order> Orders {get; set; }
    public DbSet<OrderItem> OrderItems {get; set; }
    public DbSet<PizzaPrice> PizzaPrices {get; set;}
    public DbSet<PizzaSize> PizzaSizes {get; set;}
    public DbSet<PizzaToppings> PizzaToppings {get; set;}
    public DbSet<PizzaType> PizzaTypes {get; set;}

}