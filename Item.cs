using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_226_FunctionalProgramming
{
    public class Item
    {

        string _name;
        int _stock;
        double _price;

        public Item(string name, int stock, double price)
        {
            _name = name;
            _stock = stock;
            _price = price;
        }

        public string Name { get => _name; set => _name = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public double Price { get => _price; set => _price = value; }



    }



}
