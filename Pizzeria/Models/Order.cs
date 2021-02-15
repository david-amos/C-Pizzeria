using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public double getSubtotal()
        {
            double subtotal = 0;
            foreach (Pizza p in Pizzas) {
                if(p is CustomPizza)
                {
                    CustomPizza cp = (CustomPizza)p;
                    
                    switch (cp.Size) 
                    {
                        case 'S':
                            subtotal = 8.00;
                            break;
                        case 'M':
                            subtotal = 10.00;
                            break;
                        case 'L':
                            subtotal = 12.00;
                            break;
                        default:
                            subtotal = 0;
                            break;
                    }
                    subtotal += cp.ToppingList.Count * 1;
                    if (cp.Crust.Equals("Stuffed")) 
                    {
                        subtotal += 1;
                    }
                }
                else
                {
                    switch (p.Size)
                    {
                        case 'S':
                            subtotal += 9.50;
                            break;
                        case 'M':
                            subtotal += 11.50;
                            break;
                        case 'L':
                            subtotal += 13.50;
                            break;
                        default:
                            subtotal += 0;
                            break;
                    }
                }
                
            }
            return subtotal;
            
        }
        public double getTax()
        {
            return getSubtotal() * .07;
        }
        public double getTotal()
        {
            return getSubtotal() + getTax();
        }
    }
}
