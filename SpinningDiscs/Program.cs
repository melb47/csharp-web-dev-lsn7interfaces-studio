using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            CD blah = new CD("Blah");
            DVD meh = new DVD("Meh");
           // blah.DiscSpin();
            meh.ReadDisc();
            meh.WriteDisc("Movie");
            meh.PowerLaserOn();
            meh.ReadDisc();
        }
    }
}
