using Lesson6.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class ProductInShopAtStart
    {
        internal List<Product> ListProductInShopAtStart = new List<Product>();

        Food cheese = new Food(1, 12, 56, "cheese", productType.food);
        Food milk = new Food(2, 5, 135, "milk", productType.food);
        Food butter = new Food(3, 15, 28, "butter", productType.food, 2);

        Chemicals soap = new Chemicals(4, 4, 55, "soap", productType.chemicals);
        Chemicals shampoo = new Chemicals(5, 12, 43, "shampoo", productType.chemicals);

        Machinery mixer = new Machinery(6, 86, 8, "mixer", productType.machinery);
        Machinery hoover = new Machinery(7, 101, 8, "hoover", productType.machinery);

        public ProductInShopAtStart()
        {
            ListProductInShopAtStart.Add(cheese);
            ListProductInShopAtStart.Add(milk);
            ListProductInShopAtStart.Add(butter);
            ListProductInShopAtStart.Add(soap);
            ListProductInShopAtStart.Add(shampoo);
            ListProductInShopAtStart.Add(mixer);
            ListProductInShopAtStart.Add(hoover);
        }
        
    }
}
