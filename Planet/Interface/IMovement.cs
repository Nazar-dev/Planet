using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet.Interface
{
    interface IMovement
    {
        List<int> MoveTo(List<int> foodPosition,int EssentseX, int EssentseY);
    }
}
