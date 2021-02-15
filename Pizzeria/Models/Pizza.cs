using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    
    public class Pizza 
    {
        
        public int PizzaID { get; set; }
        
        public string Name { get; set; }
        public char Size { get; set; }
        // 'S', 'M', or 'L'
        
    }
}
