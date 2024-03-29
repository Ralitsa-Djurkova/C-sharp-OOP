﻿

namespace AquaShop.Models.Fish.Contracts
{
    public class SaltwaterFish : Fish, IFish
    {
        private const int SaltwaterFishSize = 5;
        public SaltwaterFish(string name, string species, decimal price)
            : base(name, species, price)
        {
            Size = SaltwaterFishSize;
        }
        public override void Eat()
        {
            Size += 2;
        }
    }
}
