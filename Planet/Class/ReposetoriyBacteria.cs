using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planet.Interface;

namespace Planet.Class
{
    class ReposetoriyBacteria:IReposetory
    {
        private List<IEssense> _essenses = new List<IEssense>();
        private IFactory _factory;

        public ReposetoriyBacteria(IFactory _factory)
        {
            this._factory = _factory;
        }

        public List<IEssense> ReturnAllEssenses()
        {
            return _essenses;
        }

        public void CreateNewEssense()
        {
            _essenses.Add(_factory.createBacteria());
        }
    }
}
