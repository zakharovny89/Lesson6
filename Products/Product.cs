using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Products
{
    internal class Product
    {
        internal int id;
        internal decimal price;
        internal int quantity;
        internal string name;
        internal productType type;
        internal Product(int id, decimal price, int quantity, string name, productType type)
        {
            this.id = id;
            this.price = price;
            this.quantity = quantity;
            this.name = name;
            this.type = type;
        }
    }
}
