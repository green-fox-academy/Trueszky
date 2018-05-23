using System;
using System.Collections.Generic;
using System.Text;
namespace Pirates
{
    class Ships : Pirate
    {
        public string ShipName;
        public string slogen = "Ship is empty";
        public int numberOfCrew;
        public string captain;
        public List<string> captainAndTheOthers =new List<string>();
        public int CrewLimit(int crewSize)
        {
            numberOfCrew += crewSize;
            return crewSize;
        }
        public int CrewLimit()
        {
            Random rand = new Random();
            numberOfCrew = rand.Next(1, 10);
            return numberOfCrew;
        }
        public string FillShip()
        {
            CrewLimit();
            for (int i = 0; i <= numberOfCrew;i++)
            {
                if (captain == null)
                {
                    captain += Names();
                }
                else
                {
                    for (; i <= numberOfCrew - 1;)
                    {
                        captainAndTheOthers.Add(Names());
                    }
                }
            }
            return ;
        }

    }
}
