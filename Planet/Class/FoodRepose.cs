using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planet.Interface;

namespace Planet.Class
{
    class FoodRepose:IFoodRepos
    {
        private List<IFood> _food = new List<IFood>();
        private IFactory _factory;

        public FoodRepose(IFactory _factory)
        {
            this._factory = _factory;
        }


        public List<IFood> ReturAllFood()
        {
            return _food;
        }

        public void CreateNewFood()
        {
            _food.Add(_factory.createFood());
        }
    }
}
