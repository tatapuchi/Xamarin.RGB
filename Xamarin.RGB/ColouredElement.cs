using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin.RGB
{
    public class ColouredElement : ContentView
    {
        private readonly VisualElement _element;

        public ColouredElement(VisualElement element)
        {
            _element = element;
        }

        public Offset BackgroundOffset { get; set; }
        public Color BackgroundColor { 
            get { return _element.BackgroundColor; }
            set { 
                var hue = value.Hue + BackgroundOffset.HueOffset;
                var saturation = value.Saturation + BackgroundOffset.SaturationOffset;
                var luminosity = value.Luminosity + BackgroundOffset.LuminosityOffset;
                var alpha = value.A + BackgroundOffset.AlphaOffset;
                _element.BackgroundColor = Color.FromHsla(hue, saturation, luminosity, alpha);
            }
        }



    }
}