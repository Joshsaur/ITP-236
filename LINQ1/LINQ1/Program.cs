using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create sample customers
            Customer c1 = new Customer
            {
                Name = "Riven Corp",
                SalesOrders = new List<SalesOrder>
                {
                    new SalesOrder { Quantity = 10, Shipped = 8, OrderTotal = 500 },
                    new SalesOrder { Quantity = 5, Shipped = 5, OrderTotal = 250 }
                }
            };

            Customer c2 = new Customer
            {
                Name = "Storm Industries",
                SalesOrders = new List<SalesOrder>
                {
                    new SalesOrder { Quantity = 20, Shipped = 15, OrderTotal = 1000 },
                    new SalesOrder { Quantity = 3, Shipped = 3, OrderTotal = 150 }
                }
            };

            Customer c3 = new Customer
            {
                Name = "Shadow LLC",
                SalesOrders = new List<SalesOrder>
                {
                    new SalesOrder { Quantity = 7, Shipped = 4, OrderTotal = 350 }
                }
            };

            List<Customer> customers = new List<Customer> { c1, c2, c3 };

            // FOR EACH Customer
            foreach (Customer customer in customers)
            {
                customer.Display();
            }

            // FOR ALL Customers
            decimal overallAverage = customers
                .SelectMany(c => c.SalesOrders)
                .Average(o => o.OrderTotal);

            Customer highestCustomer = customers
                .OrderByDescending(c => c.OrderTotal)
                .First();

            Console.WriteLine("ALL CUSTOMERS SUMMARY");
            Console.WriteLine("Overall Average Order Size: " + overallAverage);
            Console.WriteLine("Customer with Highest Total: " + highestCustomer.Name);
            Console.WriteLine("Highest Total Amount: " + highestCustomer.OrderTotal);

            Console.ReadKey();
        }
    }
}

