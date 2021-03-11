using BorderConstrol.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderConstrol
{
    public class Citizen : IPerson, IDentifivator, IBurthable, IBuyer
    {

        public Citizen(string name, int age, string id, string birthData)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthData = DateTime.ParseExact(birthData, "dd/mm/yyyy", null);
            
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public int Food { get; private set; }

        public DateTime BirthData { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
