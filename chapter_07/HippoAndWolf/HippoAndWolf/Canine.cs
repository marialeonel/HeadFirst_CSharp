using System;
using System.Collections.Generic;
using System.Text;

namespace HippoAndWolf
{
    abstract class Canine : Animal, IPackHunter
    {
        public bool BelongsToPack { get; protected set; } = false;
    }
}
