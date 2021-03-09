
using Reading.Models;
using System;
using System.Collections.Generic;

namespace Reading
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());

            while(heroes.Count < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                BaseHero hero = CreateHeros(name, type);

                if (hero == null)
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }

                heroes.Add(hero);
            }

            int bossHealthPoints = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                bossHealthPoints -= hero.Power;
            }

            if (bossHealthPoints <= 0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static BaseHero CreateHeros(string name, string type)
        {
            BaseHero hero = null;

            if (type == nameof(Druid))
            {
                hero = new Druid(name);

            }
            else if (type == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                hero = new Warrior(name);

            }

            return hero;
        }
    }
    
}
