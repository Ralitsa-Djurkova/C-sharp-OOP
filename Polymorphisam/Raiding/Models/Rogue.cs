

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int power = 80;
        public Rogue(string type, string name) 
            : base(type, name)
        {
        }

        public  int PowerHero => power;

        public string CastAbility(string type, string name)
        {
            return $"{this.Type} - {this.Name} hit for {PowerHero} damage";
        }
    }
}
