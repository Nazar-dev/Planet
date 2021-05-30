using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Planet.Interface;

namespace Planet.Class
{
    class Food:IFood
    {
        private IRandom _random;
        private IOutPut _outPut;
        private int X;
        private int Y;

        public Food(IRandom _random, IOutPut outPut)
        {
            this._random = _random;
            this._outPut = outPut;
            createFood();
        }
        private void createFood()
        {
            X = _random.getRandInt("x");
            Y = _random.getRandInt("y");
            _outPut.setPosition(X,Y);
            _outPut.write_creature("f");
            Console.WriteLine(X + "      " + Y);
        }

        public void currentLocation()
        {
            _outPut.setPosition(X, Y);
            _outPut.write_creature("f");
        }

        public List<int> getFoodPosition()
        {
            return new List<int>() { X, Y };
        }
    }
}
