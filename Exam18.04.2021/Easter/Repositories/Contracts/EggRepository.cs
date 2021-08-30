using Easter.Models.Eggs.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Easter.Repositories.Contracts
{
    public class EggRepository : IRepository<IEgg>
    {
        private List<IEgg> models;

        public EggRepository()
        {
            models = new List<IEgg>();
        }
        public IReadOnlyCollection<IEgg> Models => this.models.AsReadOnly();

        public void Add(IEgg model)
        {
            
            models.Add(model);
        }

        public IEgg FindByName(string name)
        {
            
            return models.First(x => x.Name == name); ;
        }

        public bool Remove(IEgg model)
        {
            return models.Remove(model);
        }
    }
}
