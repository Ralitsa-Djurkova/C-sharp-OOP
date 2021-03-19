using System;

namespace SolidPrinciples
{
    public class TestClass
    {
        private string secret = "Mysicret";
        private bool isCreated = false;
        public int Age { get; set; }

        public string name;

        public TestClass()
        {
            isCreated = true;
        }

        public TestClass(string name)
            :this()
        {
            this.name = name;
        }

        public TestClass(string name, int age)
            : this(name)
        {
            this.Age = age;
        }
        public void WhoAmI()
        {
            Console.WriteLine(name);
        }

        private void TellmeSecret()
        {
            Console.WriteLine(secret);
        }
    }
}
