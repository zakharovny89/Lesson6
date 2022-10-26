using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson6.Products;

namespace Lesson6
{

    internal class UserInterface
    {


        Inventory inventory = new Inventory();

        bool exit = false;

        internal static void Greeting()
        {
            Console.WriteLine("Welcome to the shop \"Все в одном месте\"!");
        }

        internal static void SelectAction()
        {
            Console.WriteLine("Выберите, что хотите сделать (нажмите клавишу с номером):\n" +
                "1 - Вывести список продуктов в магазине;\n" +
                "2 - Вывести список продуктов в корзине;\n" +
                "3 - Вывести список еды в магазине;\n" +
                "4 - Вывести список еды в корзине;\n" +
                "5 - Вывести список бытовой химии в магазине;\n" +
                "6 - Вывести список бытовой химии в корзине;\n" +
                "7 - Вывести список бытовой техники в магазине;\n" +
                "8 - Вывести список бытовой техники в корзине;\n" +
                "9 - Добавить продукт в корзину;\n" +
                "0 - Удалить продукт из корзины;\n" +
                "A - Показать стоимость продуктов в корзине;\n" +
                "B - Совершить покупку;\n" +
                "Е - Покинуть магазин.\n");
        }

        internal void Action(string a)
        {
            switch (a)
            {

                case "1":
                    inventory.ShowProducts(inventory.ProductInShop);
                    break;
                case "2":
                    inventory.ShowProducts(inventory.ProductList);
                    break;
                case "3":
                    inventory.ShowFood(inventory.ProductInShop);
                    break;
                case "4":
                    inventory.ShowFood(inventory.ProductList);
                    break;
                case "5":
                    inventory.ShowChemicals(inventory.ProductInShop);
                    break;
                case "6":
                    inventory.ShowChemicals(inventory.ProductList);
                    break;
                case "7":
                    inventory.ShowMachinery(inventory.ProductInShop);
                    break;
                case "8":
                    inventory.ShowMachinery(inventory.ProductList);
                    break;
                case "9":

                    inventory.AddProduct();
                    break;
                case "0":
                    inventory.DeleteProduct();
                    break;
                case "A":
                    Console.WriteLine($"Сумма товаров в корзине: {inventory.CalculatePrice()}.");
                    break;
                case "B":
                    Console.WriteLine($"Спасибо за покупку. С Вас: {inventory.CalculatePrice()}. До свидания");
                    exit = true;
                    break;
                case "E":
                    Console.WriteLine("До свидания. Приходите к нам еще.");
                    exit = true;
                    return;
                default:
                    Console.WriteLine("Вы нажали неверную клавишу!");
                    break;

            }
        }

        internal void Shop()
        {
                while (!exit)
                {
                    SelectAction();
                    Action(Console.ReadLine());
                    Console.ReadLine();
                }
        }   
    }
}
