namespace Easter.Models.Dyes.Contracts
{
    public class Dye : IDye
    {
        private int power;
        public Dye(int power)
        {
            this.Power = power;
        }
        public int Power
        {
            get => this.power;
            private set
            {
                if(value < 0)
                {
                    this.Power = 0;
                }

                this.power = value;
            }
        }

        public bool IsFinished()
        {
            return Power == 0;
        }

        public void Use()
        {
            if(this.Power - 10 < 0)
            {
                this.Power = 0;
            }

            this.Power -= 10;
        }
    }
}
