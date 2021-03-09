
namespace Reading
{
    public class Druid : BaseHero
    {
        private const int HeroPower = 80;
        public Druid(string name) 
            : base(name, HeroPower)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.Name} healed for {HeroPower}";
        }
    }
}
