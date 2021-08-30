namespace Easter.Models.Bunnies.Contracts
{
    public class HappyBunny : Bunny
    {
        private const int initialEnergy = 100;
        public HappyBunny(string name) : base(name, initialEnergy)
        {
        }

        public override void Work()
        {
            if (this.Energy < 0)
            {
                this.Energy = 0;
            }

            this.Energy -= 10;
        }
    }
}
