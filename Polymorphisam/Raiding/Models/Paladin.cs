

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int power = 100;
        public Paladin(string type, string name) 
            : base(type, name)
        {
        }

        public  int PowerHero => power;

        public string CastAbility(string type, string name)
        {
            return $"{this.Type} - {this.Name} healed for {PowerHero}";
        }
    }
}
