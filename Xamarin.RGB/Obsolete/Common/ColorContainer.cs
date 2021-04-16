using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.RGB.Common
{
    public class ColorContainer
    {
        public int Hue { get; set; }
        public Range HueRange { get; set; }
        public int Saturation { get; set; }
        public Range SaturationRange { get; set; }
        public int Luminosity { get; set; }
        public Range LuminosityRange { get; set; }
        public int Alpha { get; set; }
        public Range AlphaRange { get; set; }

        public Offset Offset { get; set; }
        public Color Color { 
            get 
            {
                return Color.FromHsla(
                    Offset.ComputeValue(Hue, Offset.HueOffset, HueRange),
                    Offset.ComputeValue(Saturation, Offset.SaturationOffset, SaturationRange),
                    Offset.ComputeValue(Luminosity, Offset.LuminosityOffset, LuminosityRange),
                    Offset.ComputeValue(Alpha, Offset.AlphaOffset, AlphaRange)); ; 
            } 
        }

        public void UpdateColor(ChangeTypes types, CycleStyle style)
        {
            if (types.HasFlag(ChangeTypes.Hue))
            {

                CycleColour(Hue, HueRange, style);
            }

            if (types.HasFlag(ChangeTypes.Saturation))
            {
                CycleColour(Saturation, SaturationRange, style);
            }

            if (types.HasFlag(ChangeTypes.Luminosity))
            {
                CycleColour(Luminosity, LuminosityRange, style);
            }

            if (types.HasFlag(ChangeTypes.Alpha))
            {
                CycleColour(Alpha, AlphaRange, style);
            }

        }

        private void CycleColour(double value, Range range, CycleStyle style) 
        {
            if (style == CycleStyle.Forwards)
            {
                if (value > (range.End - 0.002)) { value = range.Start; }
                value += 0.001;
            }

            if (style == CycleStyle.Backwards)
            {
                if (value > (range.Start + 0.002)) { value = range.End; }
                value -= 0.001;
            }

            if (style == CycleStyle.Breathing)
            {
                //will implement in a bit
            }
        }

    }
}
