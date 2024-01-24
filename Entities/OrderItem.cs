using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaModels {
    public class OrderItem{
        public string Id {get; set; } = null!;
        public DrinkType DrinkType {get; set;}
        public DrinkSize DrinkSize {get; set;}
        public PizzaType PizzaType {get; set;}
        public PizzaSize PizzaSize {get; set;}

    }
}