
using Course.Entities;
using Course.Entities.Enums;
using System.Runtime.Intrinsics.X86;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { 
                Id = 1, 
                Moment = DateTime.Now, 
                Status = OrderStatus.PendingPayment };

            Console.WriteLine(order);

            /*Conversões
            Para o tipo original: use casting
            */
            OrderStatus os1 = (OrderStatus)2;
            int n1 = (int)OrderStatus.Processing;
            //string - enum:
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
