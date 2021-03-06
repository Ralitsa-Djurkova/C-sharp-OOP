using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public sealed class Kitten : Cat
    {
        private const string Kittengender = "female";
        public Kitten(string name, int age) 
            : base(name, age, Kittengender)
        {
           
        }

       public string KittenProduceSound()
        {
            return "Meow";
        }
    }
}
