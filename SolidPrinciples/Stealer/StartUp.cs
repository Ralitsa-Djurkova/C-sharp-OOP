using DocumentFormat.OpenXml.Bibliography;
using System;

namespace AuthorProblem
{
    
    public class StartUp
    {
        
        public static void Main(string[] args)
        {
            //Spy spy = new Spy();
            //string result = spy.CollectGetterAndSetter("Stealer.Hacker");
            //Console.WriteLine(result);

            var tracker = new Tracker();
            tracker.PrintMethodByAuthor();
        }
    }
}
