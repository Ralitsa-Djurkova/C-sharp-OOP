
using Raiding.Contracts;

namespace Raiding.Models
{
    public abstract class BaseHero : IBaseHero
    {
        
        public BaseHero(string name, string type)
        {
            this.Name = name;
            this.Type = type;
      
        }

        public string Type { get; private set; }
        public string Name { get; private set; }

        public int Power { get; protected set; }
       
        
    }
}
