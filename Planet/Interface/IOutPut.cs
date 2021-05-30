using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    interface IOutPut
    {
        void showPlanet();

        void setPosition(int x, int y);

        void write_creature(string creature);
    }
}
