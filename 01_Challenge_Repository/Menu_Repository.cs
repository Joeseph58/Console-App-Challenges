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
        public void AddToMenu()
        {
            if 
            {
              
            }
        }
        //get list
        public List<Menu> GetMenu()
        {

            return _menuList
        }
        ////update
        //public void UpdateMenu(update)
        //{
        //    Menu menu = new _menuList;
        //    update.example = update.Menu;
            
        //}
 
        //remove 
        public void Remove(int teamPosition)
        {
            Menu menu = _menuList;
            _menuList.Remove(menu);

        }
        //seed list
        public void SeedList()
        {

            Menu listOne = new Menu("fettuccine", "heavy cream", "butter", "parmesan" IngredientsType.fettucine);
            Menu listTwo = new Menu("dough", "sauce", "pepperoni", "cheese", IngredientsType.pizza);
            Menu listThree = new Menu("macaroni", "cream", "butter", "cheddar", IngredientsType.macaroni);

            AddToList(listOne);
            AddToList(listTwo);
            AddToList(listThree);


        }

    }
}
}
