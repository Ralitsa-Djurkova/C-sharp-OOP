
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Eggs.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Easter.Models.Workshops.Contracts
{
    public class Workshop : IWorkshop
    {
        private List<IEgg> eggs;

        public Workshop()
        {
            eggs = new List<IEgg>();
        }
        public void Color(IEgg egg, IBunny bunny)
        {
            if (bunny.Energy > 0)
            {
                
                while (bunny.Energy > 0 && bunny.Dyes.Any(x => x.IsFinished() == false) && egg.IsDone() == false)
                {
                    var dye = bunny.Dyes.First(x => x.IsFinished() == false);
                    bunny.Work();
                    dye.Use();
                    egg.GetColored();
                    
                }
               
            }
            
           

            
        }
    }
}
