
namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int power = 100;
        public Warrior(string type, string name) 
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
