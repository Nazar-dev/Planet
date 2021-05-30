using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Planet.Interface;

namespace Planet.Class
{
    class Bacteria:IEssense
    {
        private int X;
        private int Y;
        private IRandom _random;
        private IFood _iFood;
        private IOutPut _output;
        private IMovement _movement;
        public Bacteria(IRandom _random,IFood _iFood,IOutPut _outPut,IMovement movement)
        {
            this._random = _random;
            this._iFood = _iFood;
            this._output = _outPut;
            this._movement = movement;
            createEssense();
        }
        private void createEssense()
        {
            X =_random.getRandInt("x");
            Y =_random.getRandInt("y");
            _output.setPosition(X, Y);
            _output.write_creature("b");
        }

        public bool Eat()
        {
            var currentInfo = _movement.MoveTo(_iFood.getFoodPosition(),X,Y);

            if (currentInfo[0] == _iFood.getFoodPosition()[0] && currentInfo[1] == _iFood.getFoodPosition()[1])
            {
                _output.write_creature("b");
                _output.setPosition(currentInfo[0], currentInfo[1]);
                return true;
            }
            _output.setPosition(currentInfo[0], currentInfo[1]);
            _output.write_creature("b");
            return false;
        }

    }
}
