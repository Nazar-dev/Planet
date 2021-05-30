using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet.Interface
{
    interface IFood
    { 

        void currentLocation();

        List<int> getFoodPosition();
    }
}
