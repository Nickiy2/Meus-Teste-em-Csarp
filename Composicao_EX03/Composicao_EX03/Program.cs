using System;
using System.Globalization;
using Composicao_EX03.Entites;
using Composicao_EX03.Entites.Enum;

namespace Composicao_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do cliente:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Quantos itens estará neste pedido? ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do produto #{i}:");
                Console.Write("Nome do produto: ");
                string productName = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double productPrice = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Product product = new Product(productName, productPrice);

                Console.Write("Quantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantidade, productPrice, product);
                order.AddItem(orderItem);
                Console.WriteLine("-------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("RESUMO DO PEDIDO:");
            Console.WriteLine(order);
        }
    }
}