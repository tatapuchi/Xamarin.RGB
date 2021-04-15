using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.RGB
{
    public class Colourizer : IColourizer
    {
        private List<ColouredElement> elements = new List<ColouredElement>();


        public int Speed { get; set; } = 100;

        #region Colour Properties
        private double _hue = 0f;
        public double Hue { get => _hue; set => _hue = value; }

        private double _saturation = 1f;
        public double Saturation { get => _saturation; set => _saturation = value; }

        private double _luminosity = 0.5f;
        public double Luminosity { get => _luminosity; set => _luminosity = value; }

        private double _alpha = 1f;
        public double Alpha { get => _alpha; set => _alpha = value; }

        #endregion


        public Colourizer()
        {
            Task.Run(async () =>
            {

                while (true)
                {
                    UpdateColorValues();

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        foreach (var e in elements)
                        {

                            //e.BackgroundColor = Color.FromHsla(Hue, Saturation, Lightness, Alpha);+
                            e.Colourize(Color.FromHsla(Hue, Saturation, Luminosity, Alpha));
                        }
                    });

                    await Task.Delay(Speed);
                }
            });

        }

        public void Add(ColouredElement element)
        {
            elements.Add(element);
        }

    }
}
