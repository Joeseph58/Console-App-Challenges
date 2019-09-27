using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public enum IngredientsType(fettucine = 1, pizza, macaroni, meatBalls)
    public class Menu
    {
        public Menu(string base1, string sauce, string addative, string cheese)

        {

            Base1 = base1;
            Sauce = sauce;
            Addative = addative;
            Cheese = cheese;

        }
        public string Base1 { get; set; }
        public string Sauce { get; set; }
        public string Addative { get; set; }
        public string Cheese { get; set; }
    }
}
