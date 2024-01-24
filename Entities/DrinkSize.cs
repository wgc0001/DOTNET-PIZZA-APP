using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaModels{
    public class DrinkSize {
        public string Id {get; set; } = null!;
        public string DrinkSizeName {get; set; } = null!;
        public int DrinkSizePrice {get; set; }
        public List<DrinkType> DrinkTypes {get; set;}
    }
}
