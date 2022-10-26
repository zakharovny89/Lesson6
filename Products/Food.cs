using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Products
{
    internal class Food : Product
    {
        internal int weight;
        public Food(int id, decimal price, int quantity, string name, productType type) : base(id, price, quantity, name, type)
        {

        }
        //в следующий конструктор добавлен вес
        public Food(int id, decimal price, int quantity, string name, productType type, int weight) : base(id, price, quantity, name, type)
        {
            this.weight = weight;
        }
    }
}
