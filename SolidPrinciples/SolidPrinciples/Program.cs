using System;
using System.Text;

namespace SolidPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            var testType = Type.GetType("ReflectionApi.TestClass");
            TestClass test = (TestClass)Activator.CreateInstance(testType, new object[] { "Pesho", 25 });
        }
    }
}
