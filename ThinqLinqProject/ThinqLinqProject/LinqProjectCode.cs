using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinqLinqProject
{
    public partial class Customer
    {
        public const string StudentName = "Joshua Greene";

        public decimal TotalSales =>
            SalesOrders.Sum(so => so.OrderTotal);

        public int ItemsSold =>
            SalesOrders.SelectMany(so => so.SalesOrderParts)
                       .Sum(sop => sop.Quantity);

        public SalesOrder LargestSale =>
            SalesOrders.OrderByDescending(so => so.OrderTotal)
                       .FirstOrDefault();

        public List<CustomerItem> CustomerItems =>
            SalesOrders.SelectMany(so => so.SalesOrderParts)
                       .GroupBy(sop => sop.PartId)
                       .Select(g => new CustomerItem
                       (
                           CustomerId,
                           g.Key,
                           g.First().Part.Name,
                           g.Sum(x => x.Quantity),
                           g.Sum(x => x.Quantity * x.UnitPrice),
                           g.Sum(x => x.UnitsShipped),
                           g.Sum(x => x.Quantity - x.UnitsShipped)
                       ))
                       .ToList();
    }

    public partial class Part
    {
        public int QuantityOnHand =>
            ReceivedUnits - ShippedUnits - SpoiledUnits;

        public int UnitsSold =>
            SalesOrderParts.Sum(sop => sop.Quantity);

        public decimal CurrentValue =>
            QuantityOnHand * Price;

        public decimal AmountSold =>
            SalesOrderParts.Sum(sop => sop.Quantity * sop.UnitPrice);

        public List<Customer> Customers =>
            SalesOrderParts.Select(sop => sop.SalesOrder.Customer)
                           .Distinct()
                           .ToList();
    }

    public partial class SalesOrder
    {
        public int ItemsSold =>
            SalesOrderParts.Sum(sop => sop.Quantity);

        public int UnitsShipped =>
            SalesOrderParts.Sum(sop => sop.UnitsShipped);

        public int BackOrdered =>
            SalesOrderParts.Sum(sop => sop.Quantity - sop.UnitsShipped);

        public decimal OrderTotal =>
            SalesOrderParts.Sum(sop => sop.Quantity * sop.UnitPrice);

        public decimal OrderCost =>
            SalesOrderParts.Sum(sop => sop.Quantity * sop.UnitCost);

        public decimal GrossProfit =>
            OrderTotal - OrderCost;
    }
}