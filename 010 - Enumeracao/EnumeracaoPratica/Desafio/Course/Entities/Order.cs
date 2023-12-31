﻿
using System.Globalization;
using Course.Entities.Enums;
using System.Text;

namespace Course.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status {get; set;}
        public List<OrderItem> Item { get; set;} = new List<OrderItem>();
        public Client Client { get; set; }
        public Product Product { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }
        public double Total()
        {
            double sum = 0.00;
            foreach(OrderItem item in Item)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status.ToString()}");
            sb.AppendLine($"Client: {Client.Name} {Client.BirthDate} - {Client.Email}");
            sb.AppendLine();
            sb.AppendLine("Ordered items:");
            foreach (OrderItem item in Item)
            {
                sb.AppendLine($" {item.ToString()}");
            }
            sb.AppendLine($"Total price: $ {Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
            
        }

    }
}
