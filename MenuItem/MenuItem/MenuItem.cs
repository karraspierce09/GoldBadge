using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGB
{
    public class MenuItem
    {

        //Constructors
        public MenuItem() { }

        public MenuItem(int mealNum, string mealName, string description, string ingredients, decimal price)
        {
            MealNumber = mealNum;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            MealPrice = price;
        }

        //Properties
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal MealPrice { get; set; }
    }
}
