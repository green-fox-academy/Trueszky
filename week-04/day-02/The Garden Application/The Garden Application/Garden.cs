using System;
using System.Collections.Generic;
using System.Text;

namespace The_Garden_Application
{
    class Garden
    {
        private string color;
        private int waterVolume=0;
        public Garden()
        {
            
        }
        public int Watering(int volume)
        {
            return waterVolume += volume;
        }
        public int WaterVolume
        {
            get
            {
                return waterVolume;
            }
        }
    }
}
