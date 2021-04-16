using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{
    public interface IColoured
    {
        public int Speed { get; set; }

        public bool Hue { get; set; }
        public bool Saturation { get; set; }
        public bool Luminosity { get; set; }
        public bool Alpha { get; set; }
        

        public CycleStyle Style { get; set; }
    }

    public enum CycleStyle
    {
        Forwards,
        Backwards,
        Breathing
    }


}
