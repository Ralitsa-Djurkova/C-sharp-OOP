using BorderConstrol.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderConstrol.Models
{
    public class Rebel:IBuyer
    {
        private string group;
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
           this.group = group;
            
        }

        public string Name { get; set; }
        public int Age { get; set; }
        
        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
