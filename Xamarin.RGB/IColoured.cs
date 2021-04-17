using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.RGB
{
    public interface IColoured
    {
        /// <summary>
        /// Speed of colour changing in milliseconds.
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Boolean regarding whether the hue of the color should change.
        /// </summary>
        public bool Hue { get; set; }
        /// <summary>
        /// Boolean regarding whether the saturation of the color should change.
        /// </summary>
        public bool Saturation { get; set; }
        /// <summary>
        /// Boolean regarding whether the luminosity of the color should change.
        /// </summary>
        public bool Luminosity { get; set; }
        /// <summary>
        /// Boolean regarding whether the alpha value of the color should change.
        /// </summary>
        public bool Alpha { get; set; }

        /// <summary>
        /// The way the colour values should change.
        /// </summary>
        public CycleStyle Style { get; set; }
    }

    public enum CycleStyle
    {
        Forwards,
        Backwards,
        Breathing
    }



}
