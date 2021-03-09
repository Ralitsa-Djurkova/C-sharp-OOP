using ShoppingSpree.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Model
{
    public class Person
    {
        private const string NotEnoughMoneyExMsg = "{0} can't afford {1}";
        private const string SuccCoughtProductMsg = "{0} bought {1}";

        private string name;
        private decimal money;
        private readonly ICollection<Product> bag;

        private Person()
        {
            //Only initiolais to List
            this.bag = new List<Product>();
        }

        public Person(string name, decimal money) : this()
        {

            this.Name = name;
            this.Money = money;

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.EmptyNameExMsg);
                }

                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.NegativeMoneyExMsg);
                }

                this.money = value;
            }

        }

        public IReadOnlyCollection<Product> Bag
        {
            get
            {
                return (IReadOnlyCollection<Product>)this.bag;
            }

        }

        public string BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                return String.Format(NotEnoughMoneyExMsg, this.Name, product.Name);
            }
            this.Money -= product.Cost;
            this.bag.Add(product);
            return String.Format(SuccCoughtProductMsg, this.Name, product.Name);
        }
        public override string ToString()
        {
            string productsOutput = this.Bag.Count > 0 ? string.Join(", ", this.Bag) : "Nothing bought";
            return $"{this.Name} - {productsOutput}";
        }

    }
}
