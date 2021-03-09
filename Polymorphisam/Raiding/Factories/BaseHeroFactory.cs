
using Raiding.Contracts;
using Raiding.Models;
using Raiding.Untilites;
using System;

namespace Raiding.Factories
{
    public class BaseHeroFactory : IBaseHeroFactory
    {
        public IBaseHero CreateHero(string type, string name)
        {
           
            IBaseHero baseHero = null;

            if(type == nameof(Druid))
            {
                baseHero = new Druid(name, type);
            }
            else if(type == nameof(Paladin))
            {
                baseHero = new Paladin(type, name);
            }
            else if(type == nameof(Rogue))
            {
                baseHero = new Rogue(type, name);
            }
            else if(type == nameof(Warrior))
            {
                baseHero = new Warrior(type, name);
            }
            else if(type == null)
            {
                throw new ArgumentException(ExeptionMessage.InvalidHero);
            }

            return baseHero;
        }

        
    }
}
