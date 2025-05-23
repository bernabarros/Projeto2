using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Model
{
    public class Recipe : IRecipe
    {
        public string Name { get; }

        public IReadOnlyDictionary<IIngredient, int> IngredientsNeeded { get; }

        public double SuccessRate{ get; }

        public Recipe(string name, double successRate)
        {
            Name = name;
            SuccessRate = successRate;
        }

        public int CompareTo(IRecipe other)
        {
            int compare_value = 1;

            if (other == null)
            {
                compare_value = 1;
            }
            else if (other != null)
            {
                compare_value = this.Name.CompareTo(other.Name);
            }
            return compare_value;
        }
    }
}