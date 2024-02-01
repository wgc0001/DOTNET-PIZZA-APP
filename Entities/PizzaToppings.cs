using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaModels {
    public class PizzaToppings {
        public string Id {get; set;} =null!;
        public string ToppingName {get; set;} = null!;
        public List<PizzaType> PizzaTypes {get; set;}
    
    }
}
