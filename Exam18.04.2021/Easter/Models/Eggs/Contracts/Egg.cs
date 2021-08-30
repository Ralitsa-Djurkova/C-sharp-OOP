using Easter.Models.Bunnies.Contracts;
using System;

namespace Easter.Models.Eggs.Contracts
{
    public class Egg : IEgg
    {
        private string name;
        private int energyRequired;

        public Egg(int energyRequired, string name)
        {
            EnergyRequired = energyRequired;
            Name = name;
        }

        public int EnergyRequired
        {
            get => this.energyRequired;
            private set
            {
                if(value < 0)
                {
                    this.EnergyRequired = 0;
                }

                this.energyRequired = value;
            }
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Egg name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public void GetColored()
        {
            
            if(this.EnergyRequired  - 10 < 0)
            {
                this.EnergyRequired = 0;
            }
            else
            {
                this.EnergyRequired -= 10;
            }
        }

        public bool IsDone()
        {
            return EnergyRequired == 0;
        } 
        

       
    }
}
