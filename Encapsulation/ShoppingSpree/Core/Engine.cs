using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree.Model
{
    public class Engine
    {
        private readonly ICollection<Person> people;
        private readonly ICollection<Product> products;
        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {

            try
            {
                this.ParsePeopleInput();
                this.ParseProductInput();

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string personName = cmdArg[0];
                    string productName = cmdArg[1];

                    Person person = this.people.FirstOrDefault(x => x.Name == personName);
                    Product product = this.products.FirstOrDefault(x => x.Name == productName);

                    if(person != null && product != null)
                    {
                        string result = person.BuyProduct(product);
                        Console.WriteLine(result);
                    }
                }

                foreach (var item in this.people)
                {
                    Console.WriteLine(item);
                }
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }

        }

        private void ParsePeopleInput()
        {
            string[] peopleArg = Console.ReadLine().Split(';');
            foreach (string personStr in peopleArg)
            {
                string[] personArg = personStr.Split('=');

                string personName = personArg[0];
                decimal personMoney = decimal.Parse(personArg[1]);
                Person person = new Person(personName, personMoney);
                this.people.Add(person);
            }
        }
        private void ParseProductInput()
        {
            string[] productsArg = Console.ReadLine().Split(';');
            foreach (string productStr in productsArg)
            {
                string[] productArg = productStr.Split('=');

                string productName = productArg[0];
                decimal productCost = decimal.Parse(productArg[1]);
                Product product = new Product(productName, productCost);
                this.products.Add(product);
            }
        }
    }
}
