using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public  class Animals
    {
        public Animals(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        
        public override string ToString()
        {
            if(Age < 0)
            {
                throw new ArgumentException("Ivalid input");
            }
            return $"{Name} {Age} {Gender}";
        }

        
    }
}
