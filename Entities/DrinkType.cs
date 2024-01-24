using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaModels {
    public class DrinkType{
        public string Id {get; set;} = null!;
        public string DrinkTypeName {get; set;} = null!;
        public List<DrinkSize> DrinkSizes {get; set;}
        
    }
}