using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public DVD(string discName) : base(discName)
        {
            DiscSpeed = 1400;
            DiscType = "DVD";
            DiscCapacity = 16;
        }
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
