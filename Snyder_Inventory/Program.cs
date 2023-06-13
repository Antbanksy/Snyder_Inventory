// Anthony Snyder
// IT112 
// NOTES: Is this the last project?
// BEHAVIORS NOT IMPLEMENTED AND WHY: An exit option, i dont know but in the last hour ive been having a rough time remebering, and there seems to not be one?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Snyder_Inventory
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                Shipper shipper = new Shipper();

                while (true)
                {
                    Console.WriteLine("Choose from the following options:");
                    Console.WriteLine("1. Add a Bicycle to the shipment");
                    Console.WriteLine("2. Add a Lawn Mower to the shipment");
                    Console.WriteLine("3. Add a Baseball Glove to the shipment");
                    Console.WriteLine("4. Add Crackers to the shipment");
                    Console.WriteLine("5. List Shipment Items");
                    Console.WriteLine("6. Compute Shipping Charges");

                    int choice;
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                shipper.Add(new Bicycle());
                                break;
                            case 2:
                                shipper.Add(new LawnMower());
                                break;
                            case 3:
                                shipper.Add(new BaseballGlove());
                                break;
                            case 4:
                                shipper.Add(new Crackers());
                                break;
                            case 5:
                                shipper.ListItems();
                                break;
                            case 6:
                                shipper.ComputeShippingCharges();
                                return;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }

                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
    }
}
