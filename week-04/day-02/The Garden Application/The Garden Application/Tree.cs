using System;
using System.Collections.Generic;
using System.Text;

namespace The_Garden_Application
{
    class Tree : Garden
    {
        public Tree(string color) : base(color)
        {
            numberOfGreens++;
        }
    }
}
