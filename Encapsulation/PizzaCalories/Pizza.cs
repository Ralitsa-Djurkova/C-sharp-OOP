
using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int MinSymbol = 1;
        private const int MaxSymbol = 15;
        private const int MaxToppingscount = 10;

        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            toppings = new List<Topping>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < MinSymbol || value.Length > MaxSymbol)
                {
                    throw new ArgumentException($"Pizza name should be between {MinSymbol} and {MaxSymbol} symbols.");
                }
                this.name = value;
            }
        }
        

        public Dough Dough
        {
            get { return this.dough; }
            set { dough = value; }
        }
        public int CountToppings => this.toppings.Count;
        public double TotalCalories => CalculateTotalCalories();

       
        public void AddTopping(Topping topping)
        {
            if(this.toppings.Count == MaxToppingscount)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{MaxToppingscount}].");
            }

            this.toppings.Add(topping);
        }
        private double CalculateTotalCalories()
        {
            double res = this.Dough.TotalCalories;

            foreach (Topping topping in this.toppings)
            {
                res += topping.Totalcalories;
            }
            return res;
        }


    }
}
