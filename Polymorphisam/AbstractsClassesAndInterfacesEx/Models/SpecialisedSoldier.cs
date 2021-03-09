using AbstractsClassesAndInterfacesEx.Contracts;
using AbstractsClassesAndInterfacesEx.Enumarations;
using AbstractsClassesAndInterfacesEx.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = this.TryParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        private Corps TryParseCorps(string corpsStr)
        {

            bool parsed = Enum.TryParse(corpsStr, out Corps corps);

            if (!parsed)
            {
                throw new Exception();

            }
            return corps;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corps.ToString()}";
        }
    }
}
