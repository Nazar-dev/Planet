using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ninject;
using Planet.Interface;

namespace Planet.Class
{
    class Logic
    {
        private IOutPut _iOutPut;
        private IFactory _iFactory;
        private IPause _iPause;
        private IReposetory _reposetory;
        private IFoodRepos _foodRepos;

        public Logic(IOutPut _iOutPut, IFactory _iFactory,IPause _iPause,IReposetory _reposetory,IFoodRepos _foodRepos)
        {
            this._iOutPut = _iOutPut;
            this._iFactory = _iFactory;
            this._iPause = _iPause;
            this._reposetory = _reposetory;
            this._foodRepos = _foodRepos;
        }

        public void runGame()
        {
            _iOutPut.showPlanet();
            _reposetory.CreateNewEssense();
            _foodRepos.CreateNewFood();
            while (true)
            {
                _iOutPut.showPlanet();
                _foodRepos.ReturAllFood()[0].currentLocation();
                for (int i = 0; i < _reposetory.ReturnAllEssenses().Count; i++)
                {
                    if (_reposetory.ReturnAllEssenses()[i].Eat())
                        _foodRepos.ReturAllFood()[i].currentLocation();
                }
                _iPause.pause(200);
            }

            
        }

    }
}
