
using Easter.Models.Bunnies.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Easter.Repositories.Contracts
{
    public class BunnyRepository : IRepository<IBunny>
    {
        private List<IBunny> models;
        public BunnyRepository()
        {
            models = new List<IBunny>();
        }
        public IReadOnlyCollection<IBunny> Models => this.models.AsReadOnly();

        public void Add(IBunny model)
        {           
            models.Add(model);
        }

        public IBunny FindByName(string name)
        {
            //if(bunny == null)
            //{
            //    return null;
            //}

            return models.First(x => x.Name == name); ;
        }

        public bool Remove(IBunny model)
        {
            return models.Remove(model);
        }
    }
}
