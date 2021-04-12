using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.RGB.Colourizers
{
    public class ElementColourizer : ColourizerBase
    {
        private List<VisualElement> elements = new List<VisualElement>();

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
                        foreach(VisualElement e in elements)
                        {
                            e.BackgroundColor = Color.FromHsla(Hue, Saturation, Lightness, Alpha);
                        }

                    });

                    await Task.Delay(Speed);
                }


            });

        }


        public void Add(VisualElement element)
        {
            elements.Add(element);
        }

    }
}
