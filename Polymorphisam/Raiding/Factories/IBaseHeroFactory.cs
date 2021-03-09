

using Raiding.Contracts;

namespace Raiding.Factories
{
    public interface IBaseHeroFactory
    {
        IBaseHero CreateHero(string type, string name);
        
    }
}
