using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{
    public struct Offset
    {
        //Check that these values are positive and not bigger than Range.Magnitude
        public double HueOffset { get; set; }
        public Range HueRange { get; set; }
        public double SaturationOffset { get; set; }
        public Range SaturationRange { get; set; }
        public double LuminosityOffset { get; set; }
        public Range LuminosityRange { get; set; }
        public double AlphaOffset { get; set; }
        public Range AlphaRange { get; set; }

        public Offset(double hueOffset, Range hueRange,  double saturationOffset, Range saturationRange, double luminosityOffset, Range luminosityRange, double alphaOffset, Range alphaRange)
        {
            HueOffset = hueOffset;
            HueRange = hueRange;
            SaturationOffset = saturationOffset;
            SaturationRange = saturationRange;
            LuminosityOffset = luminosityOffset;
            LuminosityRange = luminosityRange;
            AlphaOffset = alphaOffset;
            AlphaRange = alphaRange;
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
