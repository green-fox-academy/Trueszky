using System;
using System.Collections.Generic;
using System.Text;

namespace The_Garden_Application
{
    class Garden
    {
        private string color;
        protected static int waterVolume = 0;
        protected static int numberOfGreens = 0;
        protected static int whoNeedWater = 0;
        public Garden()
        {

        }
        public Garden(string color)
        {
            this.color = color;
        }
        public string Watering(int volume)
        {
            waterVolume += volume;
            return string.Format("Watering with " + volume);
        }
        public int WaterVolume
        {
            get
            {
                return waterVolume;
            }

        }
        public int GetInfo()
        {
            if (Flower.waterVolume <= 4)
            {
                return whoNeedWater++;
            }
            return 0;
        }
    }
}
