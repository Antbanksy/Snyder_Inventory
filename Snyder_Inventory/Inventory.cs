using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snyder_Inventory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }

    class Bicycle : IShippable
    {
        public decimal ShipCost { get; } = 9.50m;
        public string Product { get; } = "Bicycle";
    }

    class LawnMower : IShippable
    {
        public decimal ShipCost { get; } = 24.00m;
        public string Product { get; } = "Lawn Mower";
    }

    class BaseballGlove : IShippable
    {
        public decimal ShipCost { get; } = 3.23m;
        public string Product { get; } = "Baseball Glove";
    }

    class Crackers : IShippable
    {
        public decimal ShipCost { get; } = 0.57m;
        public string Product { get; } = "Crackers";
    }

    class Shipper
    {
        private List<IShippable> items;

        public Shipper()
        {
            items = new List<IShippable>();
        }

        public void Add(IShippable item)
        {
            if (items.Count < 10)
            {
                items.Add(item);
                Console.WriteLine($"1 {item.Product} has been added");
            }
            else
            {
                Console.WriteLine("Maximum capacity reached. Cannot add more items.");
            }
        }

        public void ListItems()
        {
            Console.WriteLine("Shipment manifest:");
            var groupedItems = items.GroupBy(item => item.Product);
            foreach (var group in groupedItems)
            {
                int count = group.Count();
                string product = group.Key + (count > 1 ? "s" : "");
                Console.WriteLine($"{count} {product}");
            }
        }

        public void ComputeShippingCharges()
        {
            decimal totalCost = items.Sum(item => item.ShipCost);
            Console.WriteLine($"Total shipping cost for this order is {totalCost.ToString("C")}");
            Console.WriteLine("Press any key to terminate the program");
            Console.ReadKey();
        }
    }

    

}
