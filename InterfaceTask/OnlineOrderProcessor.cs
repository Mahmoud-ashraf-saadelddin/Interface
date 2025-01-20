using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    /*
     *   OnlineOrderProcessor:
          Processes orders placed online.
          Providesa 10%discount on all online orders
     */
    public class OnlineOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing online order ");
        }
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.10m;
        }
    }
}
