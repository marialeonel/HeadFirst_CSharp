using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballPlayers
{
    public class RetiredPlayer
    {
        public string Name { get; private set; }
        public int YearRetired { get; private set; }

        public RetiredPlayer(string name, int yearRetired)
        {
            Name = name;
            YearRetired = yearRetired;
        }



    }
}
