using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaModels {
    public class Order {
        public string Id {get; set;} = null!; 
        public ICollection<OrderItem> OrderItems {get; set;}
        public int OrderPrice {get; set; }
    }
}