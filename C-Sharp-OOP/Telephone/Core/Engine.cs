using System;
using System.Linq;
using Telephone.Contract;
using Telephone.Exeptions;
using Telephone.Models;

namespace Telephone.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private StationaryPhone stationaryPhone;
        private Smartphone smartphone;

        private Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartphone = new Smartphone();
        }
        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            string[] phoneNumber = reader.ReadLine().Split(' ').ToArray();
            string[] sites = reader.ReadLine().Split(' ').ToArray();
            CallNumbers(phoneNumber);

            BrowsSites(sites);
        }

        private void BrowsSites(string[] sites)
        {
            foreach (var url in sites)
            {
                try
                {
                    writer.WriteLine(smartphone.Brows(url));
                }
                catch (InvalidUrlexeption ex)
                {

                    writer.WriteLine(ex.Message);
                }
            }
        }

        private void CallNumbers(string[] phoneNumber)
        {
            foreach (var number in phoneNumber)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        writer.WriteLine(stationaryPhone.Call(number));
                    }
                    else if (number.Length == 10)
                    {
                        writer.WriteLine(smartphone.Call(number));
                    }
                    else
                    {
                        throw new InvalidNumberExpetion();
                    }
                }
                catch (InvalidNumberExpetion ine)
                {
                    writer.WriteLine(ine.Message);
                }

            }
        }
    }
}
