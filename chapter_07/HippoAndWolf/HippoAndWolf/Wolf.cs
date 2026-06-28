using System;
using System.Collections.Generic;
using System.Text;

namespace HippoAndWolf
{
    class Wolf : Canine
    {
        public Wolf(bool belongsToPack)
        {
            BelongsToPack = belongsToPack;
        }

        public override void MakeNoise()
        {
            if (BelongsToPack)
                Console.WriteLine("i'm in a pack");
            Console.WriteLine("aroooo!");
        }

        public void HuntInPack()
        {
            if (BelongsToPack)
                Console.WriteLine("i'm going hunting with my pack");
            Console.WriteLine("i'm not in a pack");
        }
    }
}
