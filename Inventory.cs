using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson6.Products;


namespace Lesson6
{
    internal class Inventory
    {

        internal List<Product> ProductList = new List<Product>();
        internal List<Product> ProductInShop = new List<Product>();        

        decimal totalPrice = 0;

        ProductInShopAtStart productInShopAtStart = new ProductInShopAtStart();
        public Inventory()
        {
            ProductInShop = productInShopAtStart.ListProductInShopAtStart;
        }

        internal void WriteLineProduct(Product product) //Выводит данные о продукте
        {
            Console.WriteLine($"id:{product.id}\t price:{product.price}\t quantity:{product.quantity}\t name:{product.name}\t type:{product.type}");
        }

        internal void ShowProducts(List<Product> ProductList) //Выводит данные о продуктах в списке
        {
            foreach (Product product in ProductList)
            {
                WriteLineProduct(product);
            }
        }

        internal void ShowFood(List<Product> ProductList) //Выводит данные о еде в списке
        {
            foreach (Product product in ProductList)
            {
                if (product.type == productType.food)
                {
                    WriteLineProduct(product);
                }
            }
        }
        internal void ShowChemicals(List<Product> ProductList) //Выводит данные о бытовой химии в списке
        {
            foreach (Product product in ProductList)
            {
                if (product.type == productType.chemicals)
                {
                    WriteLineProduct(product);
                }
            }
        }
        internal void ShowMachinery(List<Product> ProductList) //Выводит данные о бытовой технике в списке
        {
            foreach (Product product in ProductList)
            {
                if (product.type == productType.machinery)
                {
                    WriteLineProduct(product);
                }
            }
        }

        internal decimal CalculatePrice() //Считает стоимость продуктов в корзине
        {
            totalPrice = 0;
            foreach (Product product in ProductList)
            {
                totalPrice += product.price;
            }
            return totalPrice;
        }

        internal void AddProduct() //добывляет продукт в корзину
        {
            int id;
            Console.WriteLine("Введите id продукта.");
            id = int.Parse(Console.ReadLine());
                
            ProductList.Add(ProductInShop[id - 1]);
            Console.WriteLine($"Продукт c ID:{id} добавлен в список.");
        }

        internal void DeleteProduct() //удаляет продукт из корзины
        {
            int id;
            Console.WriteLine("Введите id продукта.");
            id = int.Parse(Console.ReadLine());
            if (ProductList.Contains(ProductInShop[id - 1]))
            {                
                ProductList.Remove(ProductInShop[id - 1]);
                Console.WriteLine($"Продукт c ID:{id} удален из списка.");
            }
            else
            {
                Console.WriteLine("Такого продукта нет в списке!");
            }
        }

    }
}
