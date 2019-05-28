using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WłasnyProjekt
{
    public class Food
    {
        public static uint Count {get;set;}
        public string Name { get; set; }
        public uint Id { get; set; }
        public double Kcal { get; set; }
        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fats{ get; set; }
        public FoodCategory foodCategory { get; set; }

        public enum FoodCategory { Drink=0, Meat=1, Vegetable=2 }

        public Food()
        {
            Count++;
            Id = Count;
        }

        public Food(string Name, double Kcal, double Protein, double Carbs, double Fats, int foodCategory)
        {
            this.Name = Name;
            this.Kcal = Kcal;
            this.Protein = Protein;
            this.Carbs = Carbs;
            this.Fats = Fats;
            this.foodCategory = (FoodCategory)foodCategory;
        }
    }

}
