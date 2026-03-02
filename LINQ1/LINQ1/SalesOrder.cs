using System;

namespace LINQ1
{
    /// <summary>
    /// Represents a sales order.
    /// </summary>
    public class SalesOrder
    {
        public int Quantity { get; set; }
        public int Shipped { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
