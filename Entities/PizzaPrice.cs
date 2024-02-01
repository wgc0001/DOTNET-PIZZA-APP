using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaModels {
    public class PizzaPrice {
        public string Id {get; set; } =null!;
        public PizzaType PizzaType {get; set; }
        public PizzaSize PizzaSize {get; set; }
        public int PizzaPriceAmount {get; set; }
        
    }
}