using _01_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Console
{
    class ProgramUI
    {
        internal class ProgramUI
        {

            Menu_Repository _menu_Repository = new Menu_Repository();
            public void Run()
            {
                _menu_Repository.SeedList();
                RunMenu();
            }
            public ProgramUI()
            {

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
                            AddToList();
                            break;
                        case "2":
                            RemoveFromList();
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

        }


    }
}
