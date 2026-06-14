using System;
using System.Collections.Generic;
using System.Text;

namespace JewelThiefConsole
{
    class SafeOwner
    {
        private string valuables = "";
        public void ReceiveContents(string safeContents)
        {
            valuables = safeContents;
            Console.WriteLine($"Thanks for returning my {valuables}!");
        }
    }
}
