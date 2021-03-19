using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string typeAnimal = Console.ReadLine();
            
            while (typeAnimal != "Beast!")
            {
                
                List<string> items = Console.ReadLine().Split().ToList();
                string name = items[0];
                int age = int.Parse(items[1]);
                string gender = items[2];
                Animals animal = new Animals(name, age, gender);
                Console.WriteLine(animal);
                typeAnimal = Console.ReadLine();
            }

            
        }
    }
}
