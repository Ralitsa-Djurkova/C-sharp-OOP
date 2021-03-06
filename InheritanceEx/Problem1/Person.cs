﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class Person
    {
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public virtual int  Age 
        {
            get { return this.age; }
            set
            {
                if(value >= 0)
                {
                    this.age = value;
                }
            } 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}, Age: {1}",
                this.Name,
                this.Age));
            return sb.ToString();
        }
    }
}