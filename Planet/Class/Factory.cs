using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planet.Interface;

namespace Planet.Class
{
    class Factory:IFactory
    {
        private IRandom _random;
        private IFood _iFood;
        private IOutPut _outPut;
        private IMovement _movement;
        public Factory(IRandom _random, IFood _iFood,IOutPut _outuPut,IMovement movement)
        {
            this._random = _random;
            this._iFood = _iFood;
            this._outPut = _outuPut;
            this._movement = movement;
        }
        public Bacteria createBacteria()
        {
            return new Bacteria(_random, _iFood,_outPut,_movement);
        }

        public Food createFood()
        {
            return new Food(_random,_outPut);
        }
    }
}
