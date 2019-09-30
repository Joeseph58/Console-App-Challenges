using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public class Menu_Repository
    {
        List<Menu> _menuList = new List<Menu>();

        

        public void AddToMenu(Menu content)
        {
            _menuList.Add(content);
        }

        //get list
        public List<Menu> GetMenu()
        {

            return _menuList;
        }

        ////update
        //public void UpdateMenu(update)
        //{
        //    Menu menu = new _menuList;
        //    update.example = update.Menu;

        //}
        public void RemoveFromMenu(int number)
        {
            foreach (Menu content in _menuList)
            {
                if (content.Number == number)
                {
                    _menuList.Remove(content);
                    break;
                }
            }
        }
    
        
        //seed list
        public void SeedList()
        {

            Menu content = new Menu(1, "fettuccine", "fettuccine alfredo", "fettuccine, alfredo sauce", "$7");
            Menu contentTwo = new Menu(2, "pizza", "pepperoni pizza", "cheese, pepperoni, pizza sauce", "$5");
            Menu contentThree = new Menu(3, "macaroni", "macaroni and cheese", "macaroni, cheddar cheese", "$3");

            AddToMenu(content);
            AddToMenu(contentTwo);
            AddToMenu(contentThree);


        }

    }
}

