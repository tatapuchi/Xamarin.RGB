using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{
    public struct Offset
    {
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
    }
}
