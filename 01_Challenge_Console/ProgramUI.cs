using _01_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Console
{
    internal class ProgramUI
    {
        Menu_Repository _menuList = new Menu_Repository();

        public ProgramUI()
        {

        }
        public void Run()
        {
            _menuList.SeedList();
            RunMenu();
        }
        public void RunMenu()
        {

            bool ContinueToRun = true;
            while (ContinueToRun)
            {
                Console.WriteLine("Welcome, enter the number of the menu item you would like to see\n" +
                       "1. Create New Order\n" +
                       "2. Remove Order\n" +
                       "3. See Order\n" +
                       "4. Exit");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddToMenu();
                        break;
                    case "2":
                        RemoveFromMenu();
                        break;
                    case "3":
                        PrintListToView();
                        break;
                    case "4":
                        ContinueToRun = false;
                        break;

                }
            }
        }

        public void AddToMenu()
        {
            Console.WriteLine("What is the number of the product you'd like to buy?");
            string mealAsString = Console.ReadLine();
            int number = int.Parse(mealAsString);

            Console.WriteLine("What is name of the meal you want", "fettucine", "pizza", "macaroni");
            string name = Console.ReadLine();

            Console.WriteLine("Description of meal");
            string descript = Console.ReadLine();
            Console.WriteLine(descript);

            Console.WriteLine("Meal ingredients");
            string ingredients = Console.ReadLine();

            Console.WriteLine("Meal price");
            string price = Console.ReadLine();
            Console.WriteLine(price);

            Menu fullConstructor = new Menu(number, name, ingredients, descript, price);

            _menuList.AddToMenu(fullConstructor);

            Console.WriteLine("Please hit any key to continue.");
            Console.ReadKey();


        }

        public void RemoveFromMenu()
        {
            Console.WriteLine("What would you like to remove");
            string Content = Console.ReadLine();
            int number = int.Parse(Content);
            _menuList.RemoveFromMenu(number);
        }

        public void PrintListToView()
        {
            List<Menu> contentList = _menuList.GetMenu();

            foreach (Menu content in contentList)
            {
                Console.WriteLine(content.Number);
                Console.WriteLine(content.Name);
                Console.WriteLine(content.Ingredients);
                Console.WriteLine(content.Descript);
                Console.WriteLine(content.Price);


            }

        }
    }
}
