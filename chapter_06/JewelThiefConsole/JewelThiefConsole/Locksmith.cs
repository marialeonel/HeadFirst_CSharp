using System;
using System.Collections.Generic;
using System.Text;

namespace JewelThiefConsole
{
    class Locksmith
    {
        public void OpenSafe(Safe safe, SafeOwner owner)
        {
            safe.PickLock(this);
            string contents = safe.Open(Combination);
            ReturnContents(contents, owner);
        }

        public string Combination { private get; set; }
        protected virtual void ReturnContents(string safeContents, SafeOwner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
