using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planet.Interface;

namespace Planet.Class
{
    class Movement:IMovement
    {
        public List<int> MoveTo(List<int> foodPosition, int EssentseX, int EssentseY)
        {
            if (EssentseX != foodPosition[0])
            {
                if (foodPosition[0] > EssentseX)
                    EssentseX++;
                else
                {
                    EssentseX--;
                }
            }

            if (EssentseY != foodPosition[1])
            {
                if (foodPosition[1] > EssentseY)
                    EssentseY++;
                else
                {
                    EssentseY--;
                }
            }

            return new List<int>() {EssentseX, EssentseY};
        }
    }
}
