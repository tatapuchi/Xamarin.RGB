using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.RGB.Colourizers
{
    /// <summary>
    /// Colourizer class for changing the backgrounds of all Xamarin.Forms controls.
    /// </summary>
    public class ElementColourizer : ColourizerBase
    {

        private List<VisualElement> elements = new List<VisualElement>();



        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public ElementColourizer()
        {

            Task.Run(async () =>
            {

                while (true)
                {
                    //Cycling Logic
                    HueCycle();
                    SaturationCycle();
                    LightnessCycle();
                    AlphaCycle();

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        foreach(var e in elements)
                        {
                            
                            //e.BackgroundColor = Color.FromHsla(Hue, Saturation, Lightness, Alpha);+
                            UpdateBackgroundColour(e);
                        }

                    });

                    await Task.Delay(Speed);
                }


            });

        }

        /// <summary>
        /// Method used to set an element to be colourized.
        /// </summary>
        /// <param name="element">Any Xamarin.Forms control.</param>
        public void Add(VisualElement element)
        {
            elements.Add(element);
        }


        #region Colour updating methods
        private void UpdateBackgroundColour(VisualElement element)
        {
                element.BackgroundColor = Color.FromHsla(Hue, Saturation, Lightness, Alpha);  
        }
        #endregion

    }
}
