using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planet.Class;

namespace Planet.Interface
{
    interface IFactory
    {
        Bacteria createBacteria();

        Food createFood();
    }
}
