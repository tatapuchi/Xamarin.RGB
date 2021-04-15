using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{
    public interface IColourizer
    {
        public CycleStyle CycleStyle { get; set; }
        public ChangeTypes ChangeFlages { get; set; }
        public ColourizerTypes ColourizerFlags { get; set; }

        public int Speed { get; set; }
        public double Hue { get; set; }
        public Range HueRange { get; set; }
        public double Saturation { get; set; }
        public Range SaturationRange { get; set; }
        public double Luminosity { get; set; }
        public Range LuminosityRange { get; set; }
        public double Alpha { get; set; }
        public Range AlphaRange { get; set; }

        public void UpdateColor();
    }
}
