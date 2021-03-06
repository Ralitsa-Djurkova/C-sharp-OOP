

using System;

namespace Problem1
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            
        }

        public override int Age
        {
            get
            {
                return base.Age; 
            }
            set
            {
                if(value > 15)
                {
                    throw new ArgumentException("Ivalid age!");
                }

                base.Age = value;
            }  

        }
    }
}
