using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaModels {
    public class PizzaType {
        public string Id {get; set; } = null!;
        public string PizzaName {get; set;} = null!;
        public string PizzaDescription {get; set;}
        public List<PizzaToppings> PizzaToppings {get; set;} 
         
    }
}