using System;
using System.Collections.Generic;
using System.Text;

namespace JewelThiefConsole
{
    internal class Safe
    {
        private string contents = "precious jewels";
        private string safeCombination = "12345";

        public string Open(string combination)
        {
            if (combination == safeCombination) return contents;
            else return "Incorrect combination. The safe remains locked.";
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.Combination = safeCombination;
        }
    }
}
