using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public sealed class Tomcat : Cat
    {
        private const string TomcatGender = "male";
        public Tomcat(string name, int age) 
            : base(name, age, TomcatGender)
        {
        }

        public string TomProduceSound()
        {
            return "MEOW";
        }
    }
}
