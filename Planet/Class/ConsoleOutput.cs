using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planet.Interface;

namespace Planet
{
    class ConsoleOutput:IOutPut
    {
        private int Weight;
        private int Height;

        public ConsoleOutput(int Weight, int Height)
        {
            this.Height = Height;
            this.Weight = Weight;
        }
        public void setPosition(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        public void showPlanet()
        {
            Console.Clear();
            for (int i = 1; i < Weight+3; i++)
            {
                setPosition(i,1);
                Console.Write("=");
            }           
            for (int i = 1; i < Weight+3; i++)
            {
                setPosition(i,Height+2);
                Console.Write("=");
            }            
            for (int i = 1; i < Height+2; i++)
            {
                setPosition(1,i);
                Console.Write("=");
            }            
            for (int i = 1; i < Height+2; i++)
            {
                setPosition(Weight+2,i);
                Console.Write("=");
            }
        }

        public void write_creature(string creature)
        {
            Console.Write(creature);
        }
    }
}
