using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{
    public struct Offset
    {
        //Check that these values are positive and not bigger than Range.Magnitude
        public double HueOffset { get; set; }
        public double SaturationOffset { get; set; }
        public double LuminosityOffset { get; set; }
        public double AlphaOffset { get; set; }

        public Offset(double hueOffset, double saturationOffset, double luminosityOffset, double alphaOffset)
        {
            HueOffset = hueOffset;
            SaturationOffset = saturationOffset;
            LuminosityOffset = luminosityOffset;
            AlphaOffset = alphaOffset;
        }

        public static double ComputeValue(double value, double offset, Range range)
        {
            if((value + offset) <= range.End) 
            { return value + offset; }
            else 
            { return (value + offset) - range.Magnitude; }
        }
    }
}
