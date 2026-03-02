using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ1
{
    /// <summary>
    /// Represents a customer with sales orders.
    /// </summary>
    public class Customer
    {
        public string Name { get; set; }

        public List<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

        /// <summary>
        /// Gets the total of all SalesOrder OrderTotal values.
        /// </summary>
        public decimal OrderTotal
        {
            get
            {
                return SalesOrders.Sum(o => o.OrderTotal);
            }
        }

        /// <summary>
        /// Gets the total backordered quantity.
        /// </summary>
        public int BackOrdered
        {
            get
            {
                return SalesOrders.Sum(o => o.Quantity - o.Shipped);
            }
        }

        /// <summary>
        /// Gets the average order size by OrderTotal.
        /// </summary>
        public decimal AverageOrderSize
        {
            get
            {
                if (SalesOrders.Count == 0)
                    return 0;

                return SalesOrders.Average(o => o.OrderTotal);
            }
        }

        /// <summary>
        /// Displays customer summary information.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Customer: " + Name);
            Console.WriteLine("Total Order Amount: " + OrderTotal);
            Console.WriteLine("Back Ordered Quantity: " + BackOrdered);
            Console.WriteLine("Average Order Size: " + AverageOrderSize);
            Console.WriteLine("--------------------------------------");
        }
    }
}
