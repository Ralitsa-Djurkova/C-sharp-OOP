

using AquaShop.Models.Aquariums.Contracts;

namespace AquaShop.Models.Fish.Contracts
{
    public class FreshwaterFish : Fish
    {
        private const int FreshwaterFishSaize = 3;
        public FreshwaterFish(string name, string species, decimal price)
            : base(name, species, price)
        {
            Size = FreshwaterFishSaize;
        }

        public override void Eat()
        {
            Size += FreshwaterFishSaize;

        }
    }
}
