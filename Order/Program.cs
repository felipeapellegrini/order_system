using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Order.Entities;
using Order.Entities.Enums;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("BirthDate: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order1 order = new Order1(DateTime.Now, status, client);


            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prdName = Console.ReadLine();
                Console.Write("Product price: ");
                double prdPrice = double.Parse(Console.ReadLine());

                Product product = new Product(prdName, prdPrice);

                Console.Write("Quantity: ");
                int prdQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(prdQuantity, prdPrice, product);

                

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.Write(order);

        }
    }
}
