
namespace Easter.Models.Bunnies.Contracts
{
    public class SleepyBunny : Bunny
    {
        private const int initialEnergy = 50;
        public SleepyBunny(string name) : base(name, initialEnergy)
        {
        }

        public override void Work()
        {
            if(this.Energy - 15 < 0)
            {
                this.Energy = 0;
            }

            this.Energy -= 15;
        }
    }
}
