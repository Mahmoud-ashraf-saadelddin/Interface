namespace InterfaceTask
{
    public class Program
    {
        /*
        * 5.    Create a console application to:
                o Allowtheusertoinput order details (Order ID, Customer Name, Order Amount,
                Order Type: Online or In-Store).
                o Processtheorder using the appropriate processor.
                o Displaythe final discounted amount.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Order ID:");
            int orderId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Order Amount:");
            decimal orderAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Order Type (Online or In-Store):");
            string orderType = Console.ReadLine();

            OrderProcessor processor = new OrderProcessor();
            IOrderProcessor orderProcessor = processor.AssignOrderProcessor(orderType);

            Order order = new Order
            {
                OrderId = orderId,
                CustomerName = customerName,
                OrderAmount = orderAmount,
                OrderProcessor = orderProcessor
            };

            orderProcessor.ProcessOrder();
            decimal discount = orderProcessor.CalculateDiscount(orderAmount);
            decimal finalAmount = orderAmount - discount;
            Console.WriteLine($"Order {order.OrderId} processed for {order.CustomerName}. Final amount after discount: ${finalAmount}");

        }
    }

}
