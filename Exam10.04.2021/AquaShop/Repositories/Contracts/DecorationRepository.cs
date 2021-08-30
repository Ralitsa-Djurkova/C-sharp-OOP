

using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace AquaShop.Repositories.Contracts
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private readonly List<IDecoration> models;
        public DecorationRepository()
        {
            models = new List<IDecoration>();
        }
        public IReadOnlyCollection<IDecoration> Models => this.models.AsReadOnly();
       

        public void Add(IDecoration model)
        {
            models.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            var model =  models.FirstOrDefault(x => x.GetType().Name == type);
            if(model == null)
            {
                return null;
            }
            return model;
        }

        public bool Remove(IDecoration model)
        {
            return models.Remove(model);
        }
    }
}
