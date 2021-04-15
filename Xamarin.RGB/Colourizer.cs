using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{
    public class Colourizer : IColourizer
    {
        public CycleStyle CycleStyle { get; set; } = CycleStyle.Forwards;
        public ChangeTypes ChangeFlages { get; set; } = ChangeTypes.Hue;
        public ColourizerTypes ColourizerFlags { get; set; } = ColourizerTypes.BackgroundColor;

        public int Speed { get; set; } = 100;
        public double Hue { get; set; } = 0f;
        public double Saturation { get; set; } = 1f;
        public double Luminosity { get; set; } = 0.5f;
        public double Alpha { get; set; } = 1f;
        public Range HueRange { get; set; } = new Range(0, 1);
        public Range SaturationRange { get; set; } = new Range(0, 1);
        public Range LuminosityRange { get; set; } = new Range(0, 1);
        public Range AlphaRange { get; set; } = new Range(0, 1);

        public void UpdateColor()
        {
            throw new NotImplementedException();
        }

    }
}
