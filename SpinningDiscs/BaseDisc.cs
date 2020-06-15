using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc : IOpticalDisc
    {
        public string Contents { get; set; }
        public int DiscSpeed { get; set; }
        public string DiscType { get; set; }
        public string DiscName { get; set; }
        public int DiscCapacity { get; set; }
        public bool Laser { get; set; } = false;
        public BaseDisc(string discName)
        {
            DiscName = discName;
        }
        public void DiscSpin()
        {
             Console.WriteLine($"This disc spins at {DiscSpeed} rpms");
         }
        public void WriteDisc(string content)
        {
            Contents = content;
        }
        public void ReadDisc()
        {
            if (Laser == true)
            {
                Console.WriteLine($"{Contents} is now playing");
            }
            else
            {
                Console.WriteLine("The laser is off, it cannot read the media");
            }
        }
        public void PowerLaserOn()
        {
            Laser = true;
        }
    }
}
