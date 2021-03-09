

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int power = 80;
        public Druid(string type, string name)
            : base(type, name)
        {
        }

        public int PowerHero => power;

        public string CastAbility(string type, string name)
        {
            return $"{this.Type} - {this.Name} healed for {PowerHero}";
        }

    }
}
