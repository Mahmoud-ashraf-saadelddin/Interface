using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    /*
     *   Create a Order class with the following properties:
         o intOrderId
         o string CustomerName
         o decimalOrderAmount
         o IOrderProcessor OrderProcessor
     */
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public IOrderProcessor OrderProcessor { get; set; }
    }
}
