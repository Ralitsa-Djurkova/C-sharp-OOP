using BorderConstrol.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderConstrol.Models
{
    public class Pet : IBurthable
    {
        public Pet(string name, string birthData)
        {
            Name = name;
            BirthData = DateTime.ParseExact(birthData, "dd/mm/yyyy", null);
        }

        public string Name { get; set; }
        
        public DateTime BirthData { get; private set; }
    }
}
