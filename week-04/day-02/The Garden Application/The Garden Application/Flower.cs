using System;
using System.Collections.Generic;
using System.Text;

namespace The_Garden_Application
{
    class Flower : Garden
    {
        public int waterLevel = 0;
        public Flower(string color) : base(color)
        {
            numberOfGreens++;
        }
        public int Watering()
        {
            if (waterLevel<=4)
            {
                
            }
        }
    }
}
