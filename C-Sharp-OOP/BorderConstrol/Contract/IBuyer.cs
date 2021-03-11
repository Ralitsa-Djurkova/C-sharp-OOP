using System;
using System.Collections.Generic;
using System.Text;

namespace BorderConstrol.Contract
{
    public interface IBuyer
    {
        public string Name { get; }
        public int Food { get;}
        void BuyFood();

    }
}
