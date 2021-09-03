using System;
using System.Collections.Generic;

namespace GaryGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Cessna mx410 = new Cessna();
            Tesla modelS = new Tesla();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
        }
    }
}
