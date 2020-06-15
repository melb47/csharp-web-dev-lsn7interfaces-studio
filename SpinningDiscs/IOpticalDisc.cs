using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        public string Contents { get; set; }
        public int DiscSpeed { get; set; }
        public string DiscType { get; set; }
        public string DiscName { get; set; }
        public int DiscCapacity { get; set; }
        public bool Laser { get; set; }
        public void DiscSpin()
        {

        }
        public void WriteDisc(string content)
        {

        }
        public void ReadDisc()
        {

        }
    }
}
