using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double BasecaloriesPerGram = 2;
        private const double MinWeight = 1;
        private const double MaxWeight = 50;

        private readonly Dictionary<string, double> DefoultTypes = new Dictionary<string, double>
        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };
        private string type;
        private double weight;
        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

       
        
        public string Type
        {
            get { return type; }
            private set
            {
                if (!this.DefoultTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value.ToLower();
            }
        }
        
        public double Weight
        {
            get { return weight; }
            private set
            {
                if(value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [{MinWeight}..{MaxWeight}].");
                }

                this.weight = value;
            }
        }
        public double CalculatePerGram => BasecaloriesPerGram *
                                          this.DefoultTypes[this.Type];
        public double Totalcalories => this.CalculatePerGram * this.Weight;


    }
}
