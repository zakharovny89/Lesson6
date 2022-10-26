using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Products
{
    internal class Chemicals : Product
    {
        public Chemicals(int id, decimal price, int quantity, string name, productType type) : base(id, price, quantity, name, type)
        {
        }
    }
}
