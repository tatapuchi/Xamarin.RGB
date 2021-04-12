using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.RGB
{
    public abstract class ColourizerBase
    {
        public ColourizationTypes ColourizerFlags { get; set; } = ColourizationTypes.HueCycle;

        private double _hue = 0f;
        public double Hue { get { return _hue; } set { if ((value >= 0) && (value <= 1)) { _hue = value; } } }

        private double _saturation = 1f;
        public double Saturation { get { return _saturation; } set { if ((value >= 0) && (value <= 1)) { _saturation = value; } } }

        private double _lightness = 0.5f;
        public double Lightness { get { return _lightness; } set { if ((value >= 0) && (value <= 1)) { _lightness = value; } } }

        private double _alpha = 1f;
        public double Alpha { get { return _alpha; } set { if ((value >= 0) && (value <= 1)) { _alpha = value; } } }

        //Speed in milliseconds

        private int _speed = 150;
        public int Speed { get { return _speed; } set { _speed = value; } }


        protected void HueCycle() 
        { 
            if(!ColourizerFlags.HasFlag(ColourizationTypes.HueCycle)) { return; }
            if(Hue > 0.998) { Hue = 0; }
            Hue += 0.001;
        }

        protected void SaturationCycle()
        {
            if (!ColourizerFlags.HasFlag(ColourizationTypes.SaturationCycle)) { return; }
            if (Saturation > 0.998) { Saturation = 0; }
            Saturation += 0.001;
        }

        protected void LightnessCycle()
        {
            if (!ColourizerFlags.HasFlag(ColourizationTypes.LightnessCycle)) { return; }
            if (Lightness > 0.998) { Lightness = 0; }
            Lightness += 0.001;
        }

        protected void AlphaCycle()
        {
            if (!ColourizerFlags.HasFlag(ColourizationTypes.AlphaCycle)) { return; }
            if (Alpha > 0.998) { Alpha = 0; }
            Alpha += 0.001;
        }


        [Flags]
        public enum ColourizationTypes
        {
            None = 0,
            HueCycle = 1,
            SaturationCycle = 1 << 1,
            LightnessCycle = 1 << 2,
            AlphaCycle = 1 << 3
        }

    }
}
