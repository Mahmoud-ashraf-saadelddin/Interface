using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    /*
      Write a method to assign the appropriate OrderProcessor based on the type of order:
      o If the order is online, use OnlineOrderProcessor.
      o If the order is in-store, use InStoreOrderProcessor
    */
    public class OrderProcessor
    {
        public IOrderProcessor AssignOrderProcessor(string Type)
        {
            switch (Type)
            {
                case "online":
                    return new OnlineOrderProcessor();
                case "in-store":
                    return new InStoreOrderProcessor();
                default:
                    throw new ArgumentException("Invalid order type. Use 'online' or 'in-store'.");
            }
        }
    }
}
