using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        public CD(string discName) : base(discName)
        {
            DiscSpeed = 400;
            DiscType = "CD";
            DiscCapacity = 1;
        }

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
