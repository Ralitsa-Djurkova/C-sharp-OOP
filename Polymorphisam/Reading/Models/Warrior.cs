
namespace Reading.Models
{
    public class Warrior : BaseHero
    {
        private const int HeroPower = 100;
        public Warrior(string name)
            : base(name, HeroPower)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.Name} hit for {HeroPower} damage";
        }
    }
}
