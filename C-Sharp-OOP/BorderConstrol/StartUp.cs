using BorderConstrol.Contract;
using BorderConstrol.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderConstrol
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var token = Console.ReadLine().Split();

                if(token.Length == 4)
                {
                    buyers.Add(new Citizen(token[0], int.Parse(token[1]), token[2], token[3]));
                }
                else if(token.Length == 3)
                {
                    buyers.Add(new Rebel(token[0], int.Parse(token[1]), token[2]));
                }
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                var buyer = buyers.SingleOrDefault(b => b.Name == command);

                if(buyer != null)
                {
                    buyer.BuyFood();
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b =>b.Food));
        }   
    }
}
