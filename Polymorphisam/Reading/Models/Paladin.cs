
namespace Reading.Models
{
    public class Paladin : BaseHero
    {
        private const int HeroPower = 100;
        public Paladin(string name) 
            : base(name, HeroPower)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.Name} healed for {HeroPower}";
        }
    }
}
