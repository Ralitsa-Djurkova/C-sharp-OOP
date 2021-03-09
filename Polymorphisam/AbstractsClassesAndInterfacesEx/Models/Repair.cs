using AbstractsClassesAndInterfacesEx.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hourWorked)
        {
            this.PartName = partName;
            this.HourWorked = hourWorked;
        }
        public string PartName { get; private set; }

        public int HourWorked { get; private set; }

        public override string ToString()
        {
            return $"  Part Name: {this.PartName} Hours Worked: {this.HourWorked}";
        }
    }
}
