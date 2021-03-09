using BorderConstrol.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderConstrol.Models
{
    public class Robot : IDentifivator, IModel, IBurthable
    {
        public Robot(string model, string id, string birthData)
        {
            Model = model;
            Id = id;
            BirthData = DateTime.ParseExact(birthData, "dd/mm/yyyy", null);
        }

        public string Model { get; private set; }

        public string Id { get; private set; }

        public DateTime BirthData { get; private set; }

        
    }
}
