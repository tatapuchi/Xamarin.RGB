using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.RGB.Colourizers
{
    /// <summary>
    /// Colourizer class for changing text colour.
    /// </summary>
    public class TextColourizer: ColourizerBase
    {

        private List<Label> labels = new List<Label>();
        private List<Entry> entries = new List<Entry>();
        private List<Editor> editors = new List<Editor>();
        //Buttons also have text
        private List<Button> buttons = new List<Button>();

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public TextColourizer()
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
                        
                        foreach (var label in labels)
                        {
                            //label.TextColor = Color.FromHsla(Hue, Saturation, Lightness, Alpha);
                            UpdateTextColour(label);
                        }

                        foreach (var entry in entries)
                        {
                            UpdateTextColour(entry);
                        }

                        foreach (var editor in editors)
                        {
                            UpdateTextColour(editor);
                        }

                        foreach (var button in buttons)
                        {
                            UpdateTextColour(button);
                        }


                    });

                    await Task.Delay(Speed);
                }


            });

        }

        /// <summary>
        /// Method used to set an element's text to be colourized.
        /// </summary>
        /// <param name="element">Any Xamarin.Forms control that implements ITextElement</param>
        public void Add(VisualElement element)
        {
            if (element is Label) { labels.Add(element as Label); return; }
            if (element is Entry) { entries.Add(element as Entry); return; }
            if (element is Editor) { editors.Add(element as Editor); return; }
            if (element is Button)
            {
                buttons.Add(element as Button); return;
            }
        }

        #region Colour Updating Methods
        private void UpdateTextColour(Label label)
        {
            label.TextColor = Color.FromHsla(Hue, Saturation, Lightness, Alpha);
        }

        private void UpdateTextColour(Entry entry)
        {
            entry.TextColor = Color.FromHsla(Hue, Saturation, Lightness, Alpha);
        }

        private void UpdateTextColour(Editor editor)
        {

            editor.TextColor = Color.FromHsla(Hue, Saturation, Lightness, Alpha);

        }

        private void UpdateTextColour(Button button)
        {
            button.TextColor = Color.FromHsla(Hue, Saturation, Lightness, Alpha);

        }
        #endregion




    }
}
