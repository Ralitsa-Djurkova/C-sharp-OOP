using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int BaseCaloriesPerGram = 2;
        private const int MinWeight = 1;
       private const int MaxWeight = 200;

        private readonly Dictionary<string, double> DefoultFlourTypes = new Dictionary<string, double>
        {
            {"white", 1.5 },
            {"wholegrain", 1.0 }
        };

        private readonly Dictionary<string, double> DefoultBackingTechnique = new Dictionary<string, double>
        {
            {"crispy",0.9 },
            {"chewy", 1.1 },
            {"homemade",1.0 }

        };
        private string flourType;
        private string backingTechnique;
        private double grams;

        public Dough(string flourType, string backingTechnique, double grams)
        {
            this.FlourType = flourType;
            this.BackingTechnique = backingTechnique;
            this.Grams = grams;
        }

        public string FlourType
        {
            get { return this.flourType; }
            private set
            {
                if (!this.DefoultFlourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value.ToLower();
            }
        }
        public string BackingTechnique
        {
            get { return this.backingTechnique; }

            private set
            {
                if (!DefoultBackingTechnique.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
               this.backingTechnique = value.ToLower();
            }
        }
        public double Grams
        {
            get
            {
                return this.grams;
            }
            private set
            {
                if(value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                }
                this.grams = value;
            }
        }
        public double CaloriesPerGram => BaseCaloriesPerGram *
            this.DefoultFlourTypes[this.FlourType] *
            this.DefoultBackingTechnique[this.BackingTechnique];
           
        public double TotalCalories => this.CaloriesPerGram * this.Grams;

    }
}
