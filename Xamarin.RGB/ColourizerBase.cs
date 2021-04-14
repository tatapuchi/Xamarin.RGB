using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.RGB
{
    /// <summary>
    /// Base class for all colourizers.
    /// </summary>
    public abstract class ColourizerBase
    {
        /// <summary>
        /// Enum flags for colourizer. 
        /// Set to HueCycle by default.
        /// </summary>
        public ColourizationTypes ColourizerFlags { get; set; } = ColourizationTypes.HueCycle;


        private double _hue = 0f;
        /// <summary>
        /// The current hue value.
        /// </summary>
        public double Hue { get { return _hue; } set { if ((value >= 0) && (value <= 1)) { _hue = value; } } }
        /// <summary>
        /// The range of possible hue values to cycle through.
        /// </summary>
        public Range HueRange { get; set; } = new Range(0, 1);


        private double _saturation = 1f;
        /// <summary>
        /// The current saturation value.
        /// </summary>
        public double Saturation { get { return _saturation; } set { if ((value >= 0) && (value <= 1)) { _saturation = value; } } }
        /// <summary>
        /// The range of possible saturation values to cycle through.
        /// </summary>
        public Range SaturationRange { get; set; } = new Range(0, 1);


        private double _lightness = 0.5f;
        /// <summary>
        /// The current lightness value.
        /// </summary>
        public double Lightness { get { return _lightness; } set { if ((value >= 0) && (value <= 1)) { _lightness = value; } } }
        /// <summary>
        /// The range of possible lightness values to cycle through.
        /// </summary>
        public Range LightnessRange { get; set; } = new Range(0, 1);


        private double _alpha = 1f;
        /// <summary>
        /// The current alpha value.
        /// </summary>
        public double Alpha { get { return _alpha; } set { if ((value >= 0) && (value <= 1)) { _alpha = value; } } }
        /// <summary>
        /// The range of possible alpha values to cycle through.
        /// </summary>
        public Range AlphaRange { get; set; } = new Range(0, 1);


        private int _speed = 150;
        /// <summary>
        /// Speed in milliseconds, of how fast the values cycle.
        /// </summary>
        public int Speed { get { return _speed; } set { _speed = value; } }

        #region Cycling Methods
        private protected void HueCycle() 
        { 
            if(!ColourizerFlags.HasFlag(ColourizationTypes.HueCycle)) { return; }
            if(Hue > (HueRange.End - 0.002)) { Hue = HueRange.Start; }
            Hue += 0.001;
        }

        private protected void SaturationCycle()
        {
            if (!ColourizerFlags.HasFlag(ColourizationTypes.SaturationCycle)) { return; }
            if (Saturation > (SaturationRange.End - 0.002)) { Saturation = SaturationRange.Start; }
            Saturation += 0.001;
        }

        private protected void LightnessCycle()
        {
            if (!ColourizerFlags.HasFlag(ColourizationTypes.LightnessCycle)) { return; }
            if (Lightness > (LightnessRange.End - 0.002)) { Lightness = LightnessRange.Start; }
            Lightness += 0.001;
        }

        private protected void AlphaCycle()
        {
            if (!ColourizerFlags.HasFlag(ColourizationTypes.AlphaCycle)) { return; }
            if (Alpha > (AlphaRange.End - 0.002)) { Alpha = AlphaRange.Start; }
            Alpha += 0.001;
        }
        #endregion


        /// <summary>
        /// An enum defining the different types of colour cycles available.
        /// </summary>
        [Flags]
        public enum ColourizationTypes
        {
            /// <summary>
            /// No colour cycling.
            /// </summary>
            None = 0,
            /// <summary>
            /// Cycling of the hue value, through the provided hue range.
            /// </summary>
            HueCycle = 1,
            /// <summary>
            /// Cycling of the saturation value, through the provided saturation range.
            /// </summary>
            SaturationCycle = 1 << 1,
            /// <summary>
            /// Cycling of the lightness value, through the provided lightness range.
            /// </summary>
            LightnessCycle = 1 << 2,
            /// <summary>
            /// Cycling of the alpha value, through the provided alpha range.
            /// </summary>
            AlphaCycle = 1 << 3
        }

    }



}
