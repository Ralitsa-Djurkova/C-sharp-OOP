

namespace AquaShop.Models.Decorations.Contracts
{
    public class Ornament : Decoration
    {
        private const int InitialComfort = 1;
        private const decimal Initialprice = 5;
        public Ornament()
            : base(InitialComfort, Initialprice)
        {
        }
    }
}
