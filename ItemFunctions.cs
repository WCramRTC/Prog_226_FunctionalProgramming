using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_226_FunctionalProgramming
{
    public static  class ItemFunctions
    {

        // Update the stock, but not effect the original item
        public static Item UpdateStock(this Item item, int newStock)
        {
            string name = item.Name;
            int stock = newStock;
            double price = item.Price;

            return new Item(name, stock, price);

        }

        public static void DisplayItem(this Item item)
        {
            Console.WriteLine($"Name: {item.Name}\n");
            Console.WriteLine($"Stock: {item.Stock}\n");
            Console.WriteLine($"Price: {item.Price}\n");
            Console.WriteLine($"\n");
        }

    }
}
