using System;
using Enum_1Ex.Entites;// Importando o namespace onde estão as classes Order e OrderStatus
using Enum_1Ex.Entites.Enums;// Importando o namespace onde estão as classes Order e OrderStatus

namespace Enum_1Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order// Instanciando um objeto do tipo Order
            {
                Id = 1750,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();// Convert enum para string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");// Convert string para enum

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}