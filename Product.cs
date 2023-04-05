using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Product
    {
        private string name, price;
        //private int price;

        public Product(string name, string price) //
        {
            this.name = name;
            this.price = price;
            
        }

        public string Name { get => name; }
        public string Price { get => price;} //
        
    }
}
