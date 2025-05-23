using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Model
{
    public class Ingredient : IIngredient
    {
        public string Name { get; }
        public string Type { get; }

        public Ingredient(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public bool Equals(IIngredient other)
        {
            bool equal_value;
            Ingredient otherIngredient = other as Ingredient;
            if (otherIngredient is null)
                equal_value = false;
            else if (Type == otherIngredient.Type &&
            Name == otherIngredient.Name)
            {
                equal_value = true;
            }
            else
            {
                equal_value = false;
            }
            return equal_value;
        }
    }
}