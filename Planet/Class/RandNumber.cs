using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planet.Interface;
using Random = System.Random;

namespace Planet.Class
{
    class RandNumber:IRandom
    {
        private int Height;
        private int Weight;
        private Random random = new Random();
        public RandNumber( int Weight, int Height)
        {
            this.Height = Height-2;
            this.Weight = Weight-2;
        }

        public int getRandInt(string kordinate)
        {

            if (kordinate == "x")
                return random.Next(2, Weight);
            return random.Next(2, Height);

        }
    }
}
