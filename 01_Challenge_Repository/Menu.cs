using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    //public enum IngredientsType(add_cheese = 1, katsup, mustard, pickles, onoins)
    public class Menu
    {
        public Menu()
        {

        }
        

        public Menu(int number, string name, string ingredients, string descript, string price)
        {
            Number = number;
            Name = name;
            Descript = descript;
            Ingredients = ingredients;
            Price = price;

        }

        public int Number { get; set; }
        public string Name { get; set; }
        public string Descript { get; set; }
        public string Ingredients { get; set; }
        public string Price { get; set; }
    }
}
