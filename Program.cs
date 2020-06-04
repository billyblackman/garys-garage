using System;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram ram2500 = new Ram();

            fxs.Drive();
            modelS.Drive();
            ram2500.Drive();

            fxs.Turn("right");
            modelS.Turn("left");
            mx410.Turn("back");
            ram2500.Turn("left");



        }
    }
}