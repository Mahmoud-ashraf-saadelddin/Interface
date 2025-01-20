using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    /*
     *  1.   Create an interface IOrderProcessor that defines the following methods:
             o voidProcessOrder();
             o decimalCalculateDiscount(decimal orderAmount);
     */
    public interface IOrderProcessor
    {
        void ProcessOrder();
        decimal CalculateDiscount(decimal orderAmount);
    }
}
