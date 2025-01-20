using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    /*
     *   InStoreOrderProcessor:
          Processes orders placed in physical stores.
          Providesa 5%discounton in-store orders.
     */
    public class InStoreOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing in-store order ");
        }
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.05m;
        }
    }
}
