using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Planet.Interface;

namespace Planet.Class
{
    class Pause:IPause
    {
        public void pause(int time)
        {
            Thread.Sleep(time);
        }
    }
}
