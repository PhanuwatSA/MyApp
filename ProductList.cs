using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class ProductList
    {
        Product product;
        List<Product> products = new List<Product>();
        private string name;
        private string price; //
        

        public void addperson2Class(Product p)
        {
            this.products.Add(p);
        }
    }
}
