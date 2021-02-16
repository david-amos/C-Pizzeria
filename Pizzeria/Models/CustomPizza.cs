using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    public class CustomPizza : Pizza
    {
        public List<String> ToppingList { get; set; }
        public String Cheese { get; set; }
        public String Crust { get; set; }
        
    }
}
