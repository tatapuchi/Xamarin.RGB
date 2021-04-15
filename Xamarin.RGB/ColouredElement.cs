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
        private readonly Entry _entry;

        public ColouredElement()
        {
            // needs to check its children
        }

        public ColouredElement(VisualElement element)
        {
            _element = element;
            if(element is Entry) { _entry = element as Entry; }
        }

        public Offset BackgroundOffset { get; set; } = new Offset(0, 0, 0, 0);
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

        public Offset TextColorOffset { get; set; } = new Offset(0,0,0,0);

        public Offset PlaceholderColorOffset { get; set; } = new Offset(0, 0, 0, 0);
    }
}